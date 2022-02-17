select distinct (prod.name, cat.name)
from producttocategory as ptc
  left join category as cat
    on cat.id = ptc.category_id
  left join product as prod
    on ptc.product_id = prod.id
union
select (prod2.name, '')
from (select (id) from product except select (product_id) from producttocategory) as prod
  left join product as prod2
    on prod.id = prod2.id

SELECT Department.DepartmentName, DepartmentLocationMapping.BlockId, DepartmentCategory.DepartmentCategoryName FROM Department
left JOIN DepartmentLocationMapping ON Department.Id = DepartmentLocationMapping.Id
left JOIN DepartmentCategory ON Department.DepartmentCategoryId = DepartmentCategory.DepartmentId


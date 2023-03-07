/** SELECT TODAS AS COLUNAS DAS TABELAS  **/
	select * from hr.locations;

	select * from hr.Departments;

	select * from hr.COUNTRIES;

	select * from hr.JOBS;

	select * from hr.regions;

	select * from hr.employees;

	select * from hr.job_HISTORY;

/** SELECIONA SOMENTE AS COLUNAS ESCOLHIDAS **/
	select D.department_id from hr.Departments D;

/** selecionar mais de uma coluna das tabelas**/

	select l.LOCATION_ID, l.CITY, l.STATE_PROVINCE from hr.locations l;

	select d.DEPARTMENT_ID, d.DEPARTMENT_NAME, d.MANAGER_ID from hr.Departments d;

	select C.COUNTRY_ID, C.COUNTRY_NAME from hr.COUNTRIES C;

	select J.JOB_TITLE, J.MAX_SALARY from hr.JOBS J;]

	select R.REGION_NAME from hr.regions R;

	select E.EMPLOYEE_ID, E.FIRST_NAME, E.LAST_NAME, E.SALARY from hr.employees E;
	
	select JH.EMPLOYEE_ID, JH.START_DATE, JH.END_DATE, JH.JOB_ID, JH.DEPARTMENT_ID from hr.job_HISTORY JH;

/** LEFT JOIN  e Alias**/
	SELECT jh.EMPLOYEE_ID as "id do funcionario", jh.start_DATE "DATA DE INCIO", e.first_name AS "Primeiro nome"  FROM hr.job_HISTORY jh
	left JOIN hr.employees e
    ON jh.EMPLOYEE_ID = e.EMPLOYEE_ID;

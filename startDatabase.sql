-- SQLite
CREATE TABLE denominations(id INTEGER PRIMARY KEY, name TEXT);
CREATE TABLE pay_schedules(id INTEGER PRIMARY KEY, name TEXT, type INTEGER, pay_rate_type INTEGER, tracking_type INTEGER, 
                           base_period_start INTEGER, base_period_end INTEGER, base_pay_day INTEGER);
CREATE TABLE workers(id INTEGER PRIMARY KEY, first_name TEXT, last_name_1 TEXT, last_name_2 TEXT, ci TEXT, pay_rate REAL, 
                     pay_rate_type INTEGER, pay_schedule_id INTEGER, denomination_id INTEGER);
CREATE TABLE tracking_entries(id INTEGER PRIMARY KEY, period INTEGER, tracking_unit INTEGER, tracking_value REAL, 
                              date INTEGER, worker_id INTEGER, payroll_id INTEGER);
CREATE TABLE payrolls(id INTEGER PRIMARY KEY, period_start INTEGER, period_end INTEGER, date INTEGER, pay_rate REAL, 
                      pay_rate_type INTEGER, tracked_time REAL, tracked_amount REAL, additionals_amount REAL,
                      balance_due REAL, pay_schedule_id INTEGER, worker_id INTEGER, pay_schedule_type INTEGER, status INTEGER);
CREATE TABLE pay_slips(id INTEGER, worker_ci TEXT, worker_full_name TEXT, tracked_work_concept TEXT, tracket_work_amount REAL,
                       payroll_total REAL, previously_paid REAL, amount REAL, is_valid INTEGER, payroll_id INTEGER);

INSERT INTO denominations(name) values("Trabajador");
INSERT INTO denominations(name) values("Contratista");

INSERT INTO pay_schedules(name, type, pay_rate_type, tracking_type, base_period_start, base_period_end, base_pay_day)
values ("Prueba", 0, 1, 3, 637749504000000000, 637753824000000000, 637753824000000000);

INSERT INTO workers(first_name, last_name_1, last_name_2, ci, pay_rate, pay_rate_type, pay_schedule_id, denomination_id)
values ("Trabajador", "Prueba", "1", "123412312", 100, 1, 1, 1);
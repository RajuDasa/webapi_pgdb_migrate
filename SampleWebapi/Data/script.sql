CREATE TABLE users (
    user_id uuid NOT NULL,
    display_name character varying(100) NOT NULL,
    country character varying(5) NOT NULL,
    payload jsonb,
    CONSTRAINT "PK_users" PRIMARY KEY (user_id)
);



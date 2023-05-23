CREATE TABLE Movies (
  movie_id INT PRIMARY KEY,
  title VARCHAR(100),
  release_year INT,
  director VARCHAR(100)
);

CREATE TABLE Actors (
  actor_id INT PRIMARY KEY,
  name VARCHAR(100),
  birth_year INT
);

-- M-M relationship.
CREATE TABLE MovieActors (
  movie_id INT,
  actor_id INT,
  FOREIGN KEY (movie_id) REFERENCES Movies(movie_id),
  FOREIGN KEY (actor_id) REFERENCES Actors(actor_id)
);

-- 1-m relationship
CREATE TABLE MovieGenres (
  movie_id INT,
  genre VARCHAR(50),
  FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);
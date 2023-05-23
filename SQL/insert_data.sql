-- Populate tables with data
INSERT INTO Movies (movie_id, title, release_year, director)
VALUES
  (1, 'Interstellar ', 2014, 'Christopher Nolan'),
  (2, 'The Avengers', 2012, 'Joss Whedon'),
  (3, 'Avatar', 2009, 'James Cameron');

INSERT INTO Actors (actor_id, name, birth_year)
VALUES
  (1, 'Matthew McConaughey', 1968),
  (2, 'Matt Damon', 1970),
  (3, 'Chris Evans', 1981),
  (4, 'Robert Downey Jr', 1965),
  (5, 'Zoe Saldana', 1978);

INSERT INTO MovieActors (movie_id, actor_id)
VALUES
  (1, 1),
  (1, 2),
  (2, 3),
  (3, 4);

INSERT INTO MovieGenres (movie_id, genre)
VALUES
  (1, 'Action'),
  (2, 'Sci-fi'),
  (3, 'Fiction'),
  (4, 'Comedy');
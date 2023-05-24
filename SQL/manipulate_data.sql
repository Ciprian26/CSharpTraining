-- Get data based on condition
SELECT *
FROM Actors
WHERE birth_year BETWEEN 1970 AND 1982;

-- Descending order of release date
SELECT *
FROM Movies
ORDER BY release_year DESC;

-- Concatenatee movies with actors
SELECT Movies.title, Actors.name
FROM Movies
JOIN MovieActors ON Movies.movie_id = MovieActors.movie_id
JOIN Actors ON MovieActors.actor_id = Actors.actor_id;

-- Update 
UPDATE Actors
SET birth_year = 1969
WHERE actor_id = 1;

-- Delete
DELETE FROM MovieGenres
WHERE genre = 'Comedy';

-- Procedure
CREATE PROCEDURE GetNumberOfMovies
AS
BEGIN
  SELECT COUNT(*) AS total_movies FROM Movies;
END;
EXEC GetNumberOfMovies;

-- Function
CREATE FUNCTION GetMovieCountByGenre(@genre VARCHAR(50))
RETURNS INT
AS
BEGIN
  DECLARE @count INT;
  SELECT @count = COUNT(*) FROM MovieGenres WHERE genre = @genre;
  RETURN @count;
END;
SELECT dbo.GetMovieCountByGenre('Action') AS action_movie_count;
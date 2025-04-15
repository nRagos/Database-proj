-- Step 1: Drop the existing foreign key if it exists
ALTER TABLE Reservations
DROP CONSTRAINT IF EXISTS [FK_Reservations_Clients];  -- Adjust if necessary

-- Step 2: Add the foreign key with cascading delete
ALTER TABLE Reservations
ADD CONSTRAINT FK_Reservations_Clients
FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
ON DELETE CASCADE;

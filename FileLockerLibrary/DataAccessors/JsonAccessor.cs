﻿using FileLockerLibrary.Models;
using System;
namespace FileLockerLibrary.DataAccessors;
/// <summary>
/// Provides methods for accessing data stored in JSON format.
/// </summary>
    /// <summary>
    /// Creates a new file model.
    /// </summary>
    /// <param name="model">The file model to create.</param>
    /// <exception cref="InvalidOperationException">Thrown when the file name already exists.</exception>
    /// <summary>
    /// Saves a file model to a JSON file.
    /// </summary>
    /// <param name="model">The file model to save.</param>
    /// <exception cref="ArgumentNullException">Thrown when the model is null.</exception>
    /// <summary>
    /// Deletes a file model.
    /// </summary>
    /// <param name="model">The file model to delete.</param>
    /// <summary>
    /// Loads all file models from JSON files.
    /// </summary>
    /// <returns>A list of file models.</returns>
    /// <summary>
    /// Relocates a file.
    /// </summary>
    /// <param name="model">The file model to relocate.</param>
    /// <param name="newPath">The new path for the file.</param>
    /// <summary>
    /// Exports a file model to a ZIP archive.
    /// </summary>
    /// <param name="model">The file model to export.</param>
    /// <param name="zipPath">The path where the ZIP archive will be saved.</param>
    /// <summary>
    /// Imports a file model from a ZIP archive.
    /// </summary>
    /// <param name="zipPath">The path to the ZIP archive.</param>
    /// <param name="savePath">The path where the file will be saved.</param>
    /// <summary>
    /// Creates a new key pair model.
    /// </summary>
    /// <param name="model">The key pair model to create.</param>
    /// <param name="password">The password for encrypting the private key.</param>
    /// <exception cref="InvalidOperationException">Thrown when the model name already exists.</exception>
    /// <summary>
    /// Deletes a key pair model.
    /// </summary>
    /// <param name="model">The key pair model to delete.</param>
    /// <summary>
    /// Loads all private key pair models from JSON files.
    /// </summary>
    /// <returns>A list of key pair models.</returns>
    /// <summary>
    /// Loads all public key pair models from JSON files.
    /// </summary>
    /// <returns>A list of key pair models.</returns>
    /// <summary>
    /// Loads all key pair models from JSON files.
    /// </summary>
    /// <returns>A list of key pair models.</returns>
    /// <summary>
    /// Exports a key pair model to a ZIP archive.
    /// </summary>
    /// <param name="model">The key pair model to export.</param>
    /// <param name="zipPath">The path where the ZIP archive will be saved.</param>
    /// <summary>
    /// Imports a key pair model from a ZIP archive.
    /// </summary>
    /// <param name="zipPath">The path to the ZIP archive containing the key pair model.</param>
    /// <exception cref="ArgumentException">Thrown when the ZIP path is null or empty.</exception>
    /// <exception cref="FileNotFoundException">Thrown when the archive does not contain the necessary file.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the key pair model already exists.</exception>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovingState : MonoBehaviour
{
    private int gameObjectIndex = -1;
    Grid grid;
    PreviewSystem previewSystem;
    GridData floorData;
    GridData normalObjectsData;
    ObjectPlacer objectPlacer;

    public RemovingState(Grid grid,
                         PreviewSystem previewSystem,
                         GridData floorData,
                         GridData normalObjectsData,
                         ObjectPlacer objectPlacer)
    {
        this.grid = grid;
        this.previewSystem = previewSystem;
        this.floorData = floorData;
        this.normalObjectsData = normalObjectsData;
        this.objectPlacer = objectPlacer;

        previewSystem.StartShowingRemovePreview();
    }
}

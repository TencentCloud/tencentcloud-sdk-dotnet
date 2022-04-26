/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventContent : AbstractModel
    {
        
        /// <summary>
        /// 事件类型，可取值有：
        /// <li>Storage.NewFileCreated：新文件产生事件；</li>
        /// <li>Project.StreamConnect.StatusChanged：云转推项目状态变更事件；</li>
        /// <li>Project.Switcher.StatusChanged：导播台项目状态变更事件；</li>
        /// <li>Material.Imported：媒体导入事件；</li>
        /// <li>Material.Added：媒体添加事件；</li>
        /// <li>Material.Moved：媒体移动事件；</li>
        /// <li>Material.Modified：媒体变更事件；</li>
        /// <li>Material.Deleted：媒体删除事件；</li>
        /// <li>Class.Created：分类新增事件；</li>
        /// <li>Class.Moved：分类移动事件；</li>
        /// <li>Class.Deleted：分类删除事件；</li>
        /// <li>Task.VideoExportCompleted：视频导出完成事件。 </li>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 操作者，表示触发事件的操作者。如果是 `cmeid_system` 表示平台管理员操作。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 新文件产生事件。仅当 EventType 为 Storage.NewFileCreated 时有效。
        /// </summary>
        [JsonProperty("StorageNewFileCreatedEvent")]
        public StorageNewFileCreatedEvent StorageNewFileCreatedEvent{ get; set; }

        /// <summary>
        /// 云转推项目状态变更事件。仅当 EventType 为 Project.StreamConnect.StatusChanged 时有效。
        /// </summary>
        [JsonProperty("ProjectStreamConnectStatusChangedEvent")]
        public ProjectStreamConnectStatusChangedEvent ProjectStreamConnectStatusChangedEvent{ get; set; }

        /// <summary>
        /// 导播台项目状态变更事件。仅当 EventType 为 Project.Switcher.StatusChanged 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectSwitcherStatusChangedEvent")]
        public ProjectSwitcherStatusChangedEvent ProjectSwitcherStatusChangedEvent{ get; set; }

        /// <summary>
        /// 媒体导入事件。仅当 EventType 为 Material.Imported 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialImportedEvent")]
        public MaterialImportedEvent MaterialImportedEvent{ get; set; }

        /// <summary>
        /// 媒体添加事件。仅当 EventType 为 Material.Added 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialAddedEvent")]
        public MaterialAddedEvent MaterialAddedEvent{ get; set; }

        /// <summary>
        /// 媒体移动事件。仅当 EventType 为 Material.Moved 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialMovedEvent")]
        public MaterialMovedEvent MaterialMovedEvent{ get; set; }

        /// <summary>
        /// 媒体更新事件。仅当 EventType 为 Material.Modified 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialModifiedEvent")]
        public MaterialModifiedEvent MaterialModifiedEvent{ get; set; }

        /// <summary>
        /// 媒体删除事件。仅当 EventType 为 Material.Deleted 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialDeletedEvent")]
        public MaterialDeletedEvent MaterialDeletedEvent{ get; set; }

        /// <summary>
        /// 分类创建事件。仅当 EventType 为 Class.Created 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassCreatedEvent")]
        public ClassCreatedEvent ClassCreatedEvent{ get; set; }

        /// <summary>
        /// 分类移动事件。仅当 EventType 为 Class.Moved 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassMovedEvent")]
        public ClassMovedEvent ClassMovedEvent{ get; set; }

        /// <summary>
        /// 分类删除事件。仅当 EventType 为 Class.Deleted 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassDeletedEvent")]
        public ClassDeletedEvent ClassDeletedEvent{ get; set; }

        /// <summary>
        /// 视频导出完成事件。仅当 EventType 为 Task.VideoExportCompleted 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoExportCompletedEvent")]
        public VideoExportCompletedEvent VideoExportCompletedEvent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamObj(map, prefix + "StorageNewFileCreatedEvent.", this.StorageNewFileCreatedEvent);
            this.SetParamObj(map, prefix + "ProjectStreamConnectStatusChangedEvent.", this.ProjectStreamConnectStatusChangedEvent);
            this.SetParamObj(map, prefix + "ProjectSwitcherStatusChangedEvent.", this.ProjectSwitcherStatusChangedEvent);
            this.SetParamObj(map, prefix + "MaterialImportedEvent.", this.MaterialImportedEvent);
            this.SetParamObj(map, prefix + "MaterialAddedEvent.", this.MaterialAddedEvent);
            this.SetParamObj(map, prefix + "MaterialMovedEvent.", this.MaterialMovedEvent);
            this.SetParamObj(map, prefix + "MaterialModifiedEvent.", this.MaterialModifiedEvent);
            this.SetParamObj(map, prefix + "MaterialDeletedEvent.", this.MaterialDeletedEvent);
            this.SetParamObj(map, prefix + "ClassCreatedEvent.", this.ClassCreatedEvent);
            this.SetParamObj(map, prefix + "ClassMovedEvent.", this.ClassMovedEvent);
            this.SetParamObj(map, prefix + "ClassDeletedEvent.", this.ClassDeletedEvent);
            this.SetParamObj(map, prefix + "VideoExportCompletedEvent.", this.VideoExportCompletedEvent);
        }
    }
}


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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportSnapshotsRequest : AbstractModel
    {
        
        /// <summary>
        /// 表格所属的集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 用于导入的快照信息
        /// </summary>
        [JsonProperty("Snapshots")]
        public SnapshotInfo Snapshots{ get; set; }

        /// <summary>
        /// 是否导入部分记录，TRUE表示导入部分记录，FALSE表示全表导入
        /// </summary>
        [JsonProperty("ImportSpecialKey")]
        public string ImportSpecialKey{ get; set; }

        /// <summary>
        /// 是否导入到当前表，TRUE表示导入到当前表，FALSE表示导入到新表
        /// </summary>
        [JsonProperty("ImportOriginTable")]
        public string ImportOriginTable{ get; set; }

        /// <summary>
        /// 部分记录的key文件
        /// </summary>
        [JsonProperty("KeyFile")]
        public KeyFile KeyFile{ get; set; }

        /// <summary>
        /// 如果导入到新表，此为新表所属的表格组id
        /// </summary>
        [JsonProperty("NewTableGroupId")]
        public string NewTableGroupId{ get; set; }

        /// <summary>
        /// 如果导入到新表，此为新表的表名，系统会以该名称自动创建一张结构相同的空表
        /// </summary>
        [JsonProperty("NewTableName")]
        public string NewTableName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "Snapshots.", this.Snapshots);
            this.SetParamSimple(map, prefix + "ImportSpecialKey", this.ImportSpecialKey);
            this.SetParamSimple(map, prefix + "ImportOriginTable", this.ImportOriginTable);
            this.SetParamObj(map, prefix + "KeyFile.", this.KeyFile);
            this.SetParamSimple(map, prefix + "NewTableGroupId", this.NewTableGroupId);
            this.SetParamSimple(map, prefix + "NewTableName", this.NewTableName);
        }
    }
}


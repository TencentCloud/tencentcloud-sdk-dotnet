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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataConfig : AbstractModel
    {
        
        /// <summary>
        /// 映射路径
        /// </summary>
        [JsonProperty("MappingPath")]
        public string MappingPath{ get; set; }

        /// <summary>
        /// 存储用途
        /// 可选值为 BUILTIN_CODE, BUILTIN_DATA, BUILTIN_MODEL, USER_DATA, USER_CODE, USER_MODEL, OUTPUT, OTHER
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceUsage")]
        public string DataSourceUsage{ get; set; }

        /// <summary>
        /// DATASET、COS、CFS、CFSTurbo、GooseFSx、HDFS、WEDATA_HDFS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// 来自数据集的数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSetSource")]
        public DataSetConfig DataSetSource{ get; set; }

        /// <summary>
        /// 来自cos的数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("COSSource")]
        public CosPathInfo COSSource{ get; set; }

        /// <summary>
        /// 来自CFS的数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSSource")]
        public CFSConfig CFSSource{ get; set; }

        /// <summary>
        /// 来自HDFS的数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HDFSSource")]
        public HDFSConfig HDFSSource{ get; set; }

        /// <summary>
        /// 配置GooseFS的数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GooseFSSource")]
        public GooseFS GooseFSSource{ get; set; }

        /// <summary>
        /// 配置TurboFS的数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSTurboSource")]
        public CFSTurbo CFSTurboSource{ get; set; }

        /// <summary>
        /// 来自本地磁盘的信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDiskSource")]
        public LocalDisk LocalDiskSource{ get; set; }

        /// <summary>
        /// CBS配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CBSSource")]
        public CBSConfig CBSSource{ get; set; }

        /// <summary>
        /// 主机路径信息
        /// </summary>
        [JsonProperty("HostPathSource")]
        public HostPath HostPathSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MappingPath", this.MappingPath);
            this.SetParamSimple(map, prefix + "DataSourceUsage", this.DataSourceUsage);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamObj(map, prefix + "DataSetSource.", this.DataSetSource);
            this.SetParamObj(map, prefix + "COSSource.", this.COSSource);
            this.SetParamObj(map, prefix + "CFSSource.", this.CFSSource);
            this.SetParamObj(map, prefix + "HDFSSource.", this.HDFSSource);
            this.SetParamObj(map, prefix + "GooseFSSource.", this.GooseFSSource);
            this.SetParamObj(map, prefix + "CFSTurboSource.", this.CFSTurboSource);
            this.SetParamObj(map, prefix + "LocalDiskSource.", this.LocalDiskSource);
            this.SetParamObj(map, prefix + "CBSSource.", this.CBSSource);
            this.SetParamObj(map, prefix + "HostPathSource.", this.HostPathSource);
        }
    }
}


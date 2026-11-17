/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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
        /// <p>映射路径</p>
        /// </summary>
        [JsonProperty("MappingPath")]
        public string MappingPath{ get; set; }

        /// <summary>
        /// <p>存储用途，用于标识该数据配置中数据的使用场景。</p><p>枚举值：</p><ul><li>BUILTIN_CODE： 内置代码</li><li>BUILTIN_DATA： 内置数据</li><li>BUILTIN_MODEL： 内置模型</li><li>USER_DATA： 用户数据</li><li>USER_CODE： 用户代码</li><li>USER_MODEL： 用户模型</li><li>OUTPUT： 训练输出</li><li>DEFAULT： 其他</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceUsage")]
        public string DataSourceUsage{ get; set; }

        /// <summary>
        /// <p>存储类型，各取值对应的数据结构见下方枚举值说明。</p><p>枚举值：</p><ul><li>DATASET： 数据集，填 DataSetSource</li><li>COS： COS 对象存储，填 COSSource；仅 Train 支持</li><li>COSFS： COS 挂载（COSFS），填 COSSource</li><li>CFS： CFS 文件存储，填 CFSSource</li><li>CFSTurbo： CFSTurbo 文件存储，填 CFSSource；兼容历史字段 CFSTurboSource；仅 Train 支持</li><li>GooseFS： GooseFS 实例，填 GooseFSSource</li><li>GooseFSx： GooseFSx 实例，填 GooseFSSource</li><li>HDFS： HDFS 存储，填 HDFSSource；仅 Train 支持</li><li>LOCAL_DISK： 本地磁盘，填 LocalDiskSource</li><li>HOST_PATH： 宿主机路径，填 HostPathSource</li><li>PUBLIC_DATA_SOURCE： 公有云数据源，填 PublicDataSource</li><li>CLOUD_PREMIUM： 高性能云硬盘（CBS），填 CBSSource，需指定 VolumeSizeInGB；仅 Notebook 支持</li><li>CLOUD_SSD： SSD 云硬盘（CBS），填 CBSSource，需指定 VolumeSizeInGB；仅 Notebook 支持</li><li>FREE： 免费云硬盘（CBS），填 CBSSource；仅 Notebook 支持</li><li>CFS_TURBO： CFSTurbo 文件存储，填 CFSSource；仅 Notebook 支持</li><li>BUILTIN_DATASET： 平台内置数据集，填 DataSetSource</li><li>PRELOAD_FILE： 预加载文件，填 PreloadFileSource</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// <p>来自数据集的数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSetSource")]
        public DataSetConfig DataSetSource{ get; set; }

        /// <summary>
        /// <p>来自cos的数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("COSSource")]
        public CosPathInfo COSSource{ get; set; }

        /// <summary>
        /// <p>来自CFS的数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSSource")]
        public CFSConfig CFSSource{ get; set; }

        /// <summary>
        /// <p>来自HDFS的数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HDFSSource")]
        public HDFSConfig HDFSSource{ get; set; }

        /// <summary>
        /// <p>配置GooseFS的数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GooseFSSource")]
        public GooseFS GooseFSSource{ get; set; }

        /// <summary>
        /// <p>配置TurboFS的数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSTurboSource")]
        public CFSTurbo CFSTurboSource{ get; set; }

        /// <summary>
        /// <p>来自本地磁盘的信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDiskSource")]
        public LocalDisk LocalDiskSource{ get; set; }

        /// <summary>
        /// <p>CBS配置信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CBSSource")]
        public CBSConfig CBSSource{ get; set; }

        /// <summary>
        /// <p>主机路径信息</p>
        /// </summary>
        [JsonProperty("HostPathSource")]
        public HostPath HostPathSource{ get; set; }

        /// <summary>
        /// <p>公有云数据源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicDataSource")]
        public PublicDataSourceFS PublicDataSource{ get; set; }

        /// <summary>
        /// <p>是否是只读存储</p>
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }


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
            this.SetParamObj(map, prefix + "PublicDataSource.", this.PublicDataSource);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
        }
    }
}


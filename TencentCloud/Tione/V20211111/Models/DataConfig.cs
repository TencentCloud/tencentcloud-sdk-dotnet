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
        /// DATASET、COS、CFS、HDFS
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MappingPath", this.MappingPath);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamObj(map, prefix + "DataSetSource.", this.DataSetSource);
            this.SetParamObj(map, prefix + "COSSource.", this.COSSource);
            this.SetParamObj(map, prefix + "CFSSource.", this.CFSSource);
            this.SetParamObj(map, prefix + "HDFSSource.", this.HDFSSource);
        }
    }
}


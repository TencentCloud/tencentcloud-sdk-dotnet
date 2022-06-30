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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DMSSds : AbstractModel
    {
        
        /// <summary>
        /// 存储地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 输入格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputFormat")]
        public string InputFormat{ get; set; }

        /// <summary>
        /// 输出格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// bucket数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumBuckets")]
        public long? NumBuckets{ get; set; }

        /// <summary>
        /// 是是否压缩
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compressed")]
        public bool? Compressed{ get; set; }

        /// <summary>
        /// 是否有子目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoredAsSubDirectories")]
        public bool? StoredAsSubDirectories{ get; set; }

        /// <summary>
        /// 序列化lib
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerdeLib")]
        public string SerdeLib{ get; set; }

        /// <summary>
        /// 序列化名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerdeName")]
        public string SerdeName{ get; set; }

        /// <summary>
        /// 桶名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketCols")]
        public string[] BucketCols{ get; set; }

        /// <summary>
        /// 序列化参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerdeParams")]
        public KVPair[] SerdeParams{ get; set; }

        /// <summary>
        /// 附加参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public KVPair[] Params{ get; set; }

        /// <summary>
        /// 列排序(Expired)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SortCols")]
        public DMSColumnOrder SortCols{ get; set; }

        /// <summary>
        /// 列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cols")]
        public DMSColumn[] Cols{ get; set; }

        /// <summary>
        /// 列排序字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SortColumns")]
        public DMSColumnOrder[] SortColumns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "InputFormat", this.InputFormat);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "NumBuckets", this.NumBuckets);
            this.SetParamSimple(map, prefix + "Compressed", this.Compressed);
            this.SetParamSimple(map, prefix + "StoredAsSubDirectories", this.StoredAsSubDirectories);
            this.SetParamSimple(map, prefix + "SerdeLib", this.SerdeLib);
            this.SetParamSimple(map, prefix + "SerdeName", this.SerdeName);
            this.SetParamArraySimple(map, prefix + "BucketCols.", this.BucketCols);
            this.SetParamArrayObj(map, prefix + "SerdeParams.", this.SerdeParams);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamObj(map, prefix + "SortCols.", this.SortCols);
            this.SetParamArrayObj(map, prefix + "Cols.", this.Cols);
            this.SetParamArrayObj(map, prefix + "SortColumns.", this.SortColumns);
        }
    }
}


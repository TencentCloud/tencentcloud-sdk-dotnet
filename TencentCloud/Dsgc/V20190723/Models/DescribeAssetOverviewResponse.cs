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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据库实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBInstanceNums")]
        public long? DBInstanceNums{ get; set; }

        /// <summary>
        /// 数据库个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBNums")]
        public long? DBNums{ get; set; }

        /// <summary>
        /// 表的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableNums")]
        public long? TableNums{ get; set; }

        /// <summary>
        /// 字段个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldNums")]
        public long? FieldNums{ get; set; }

        /// <summary>
        /// 数据库实例的分布情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBInstanceDistribution")]
        public Note[] DBInstanceDistribution{ get; set; }

        /// <summary>
        /// db分布情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBDistribution")]
        public Note[] DBDistribution{ get; set; }

        /// <summary>
        /// cos桶的数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketNums")]
        public long? BucketNums{ get; set; }

        /// <summary>
        /// 文件个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileNums")]
        public long? FileNums{ get; set; }

        /// <summary>
        /// 用于对用户进行提示信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// es实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsInstanceNums")]
        public ulong? EsInstanceNums{ get; set; }

        /// <summary>
        /// es索引数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsIndexNums")]
        public ulong? EsIndexNums{ get; set; }

        /// <summary>
        /// es字段数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsFieldNums")]
        public ulong? EsFieldNums{ get; set; }

        /// <summary>
        /// mongo实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoInstanceNums")]
        public ulong? MongoInstanceNums{ get; set; }

        /// <summary>
        /// mongo数据库数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoDbNums")]
        public ulong? MongoDbNums{ get; set; }

        /// <summary>
        /// mongo集合数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoColNums")]
        public ulong? MongoColNums{ get; set; }

        /// <summary>
        /// mongo字段数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoFieldNums")]
        public ulong? MongoFieldNums{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceNums", this.DBInstanceNums);
            this.SetParamSimple(map, prefix + "DBNums", this.DBNums);
            this.SetParamSimple(map, prefix + "TableNums", this.TableNums);
            this.SetParamSimple(map, prefix + "FieldNums", this.FieldNums);
            this.SetParamArrayObj(map, prefix + "DBInstanceDistribution.", this.DBInstanceDistribution);
            this.SetParamArrayObj(map, prefix + "DBDistribution.", this.DBDistribution);
            this.SetParamSimple(map, prefix + "BucketNums", this.BucketNums);
            this.SetParamSimple(map, prefix + "FileNums", this.FileNums);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "EsInstanceNums", this.EsInstanceNums);
            this.SetParamSimple(map, prefix + "EsIndexNums", this.EsIndexNums);
            this.SetParamSimple(map, prefix + "EsFieldNums", this.EsFieldNums);
            this.SetParamSimple(map, prefix + "MongoInstanceNums", this.MongoInstanceNums);
            this.SetParamSimple(map, prefix + "MongoDbNums", this.MongoDbNums);
            this.SetParamSimple(map, prefix + "MongoColNums", this.MongoColNums);
            this.SetParamSimple(map, prefix + "MongoFieldNums", this.MongoFieldNums);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


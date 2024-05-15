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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosParam : AbstractModel
    {
        
        /// <summary>
        /// cos 存储桶名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 地域代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 对象名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectKey")]
        public string ObjectKey{ get; set; }

        /// <summary>
        /// 汇聚消息量的大小（单位：MB)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AggregateBatchSize")]
        public ulong? AggregateBatchSize{ get; set; }

        /// <summary>
        /// 汇聚的时间间隔（单位：小时）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AggregateInterval")]
        public ulong? AggregateInterval{ get; set; }

        /// <summary>
        /// 消息汇聚后的文件格式（支持csv, json）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FormatOutputType")]
        public string FormatOutputType{ get; set; }

        /// <summary>
        /// 转储的对象目录前缀
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectKeyPrefix")]
        public string ObjectKeyPrefix{ get; set; }

        /// <summary>
        /// 根据strptime 时间格式化的分区格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DirectoryTimeFormat")]
        public string DirectoryTimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ObjectKey", this.ObjectKey);
            this.SetParamSimple(map, prefix + "AggregateBatchSize", this.AggregateBatchSize);
            this.SetParamSimple(map, prefix + "AggregateInterval", this.AggregateInterval);
            this.SetParamSimple(map, prefix + "FormatOutputType", this.FormatOutputType);
            this.SetParamSimple(map, prefix + "ObjectKeyPrefix", this.ObjectKeyPrefix);
            this.SetParamSimple(map, prefix + "DirectoryTimeFormat", this.DirectoryTimeFormat);
        }
    }
}


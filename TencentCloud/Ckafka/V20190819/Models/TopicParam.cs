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

    public class TopicParam : AbstractModel
    {
        
        /// <summary>
        /// 单独售卖Topic的Topic名称
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// Offset类型，最开始位置earliest，最新位置latest，时间点位置timestamp
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OffsetType")]
        public string OffsetType{ get; set; }

        /// <summary>
        /// Offset类型为timestamp时必传，传时间戳，精确到秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// Topic的TopicId【出参】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 写入Topic时是否进行压缩，不开启填"none"，开启的话，可选择"gzip", "snappy", "lz4"中的一个进行填写。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompressionType")]
        public string CompressionType{ get; set; }

        /// <summary>
        /// 使用的Topic是否需要自动创建（目前只支持SOURCE流入任务）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseAutoCreateTopic")]
        public bool? UseAutoCreateTopic{ get; set; }

        /// <summary>
        /// 源topic消息1条扩增成msgMultiple条写入目标topic(该参数目前只有ckafka流入ckafka适用)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgMultiple")]
        public long? MsgMultiple{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "OffsetType", this.OffsetType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "CompressionType", this.CompressionType);
            this.SetParamSimple(map, prefix + "UseAutoCreateTopic", this.UseAutoCreateTopic);
            this.SetParamSimple(map, prefix + "MsgMultiple", this.MsgMultiple);
        }
    }
}


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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatahubTopicDTO : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Topic名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Topic Id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 分区数
        /// </summary>
        [JsonProperty("PartitionNum")]
        public ulong? PartitionNum{ get; set; }

        /// <summary>
        /// 过期时间，单位ms
        /// </summary>
        [JsonProperty("RetentionMs")]
        public ulong? RetentionMs{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 状态，1使用中，2删除中
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "RetentionMs", this.RetentionMs);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}


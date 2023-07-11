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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateKeywordsSamplesResponse : AbstractModel
    {
        
        /// <summary>
        /// 添加成功的关键词ID列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleIDs")]
        public string[] SampleIDs{ get; set; }

        /// <summary>
        /// 成功入库关键词列表
        /// </summary>
        [JsonProperty("SuccessInfos")]
        public UserKeywordInfo[] SuccessInfos{ get; set; }

        /// <summary>
        /// 重复关键词列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DupInfos")]
        public UserKeywordInfo[] DupInfos{ get; set; }

        /// <summary>
        /// 无效关键词列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvalidSamples")]
        public InvalidSample[] InvalidSamples{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SampleIDs.", this.SampleIDs);
            this.SetParamArrayObj(map, prefix + "SuccessInfos.", this.SuccessInfos);
            this.SetParamArrayObj(map, prefix + "DupInfos.", this.DupInfos);
            this.SetParamArrayObj(map, prefix + "InvalidSamples.", this.InvalidSamples);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


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

    public class TopicRetentionTimeConfigRsp : AbstractModel
    {
        
        /// <summary>
        /// 期望值，即用户配置的Topic消息保留时间(单位分钟)
        /// </summary>
        [JsonProperty("Expect")]
        public long? Expect{ get; set; }

        /// <summary>
        /// 当前值，即当前生效值(可能存在动态调整，单位分钟)
        /// </summary>
        [JsonProperty("Current")]
        public long? Current{ get; set; }

        /// <summary>
        /// 最近变更时间
        /// </summary>
        [JsonProperty("ModTimeStamp")]
        public long? ModTimeStamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Expect", this.Expect);
            this.SetParamSimple(map, prefix + "Current", this.Current);
            this.SetParamSimple(map, prefix + "ModTimeStamp", this.ModTimeStamp);
        }
    }
}


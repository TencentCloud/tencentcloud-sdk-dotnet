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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IMCdrInfo : AbstractModel
    {
        
        /// <summary>
        /// 服务记录ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 服务时长秒数
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 结束状态
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 服务类型 1为全媒体，2为文本客服
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 客服ID
        /// </summary>
        [JsonProperty("StaffId")]
        public string StaffId{ get; set; }

        /// <summary>
        /// 服务时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "EndStatus", this.EndStatus);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StaffId", this.StaffId);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
        }
    }
}


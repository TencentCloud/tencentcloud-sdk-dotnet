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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOnCallFormRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定值，为"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 值班表名称
        /// </summary>
        [JsonProperty("OnCallFormName")]
        public string OnCallFormName{ get; set; }

        /// <summary>
        /// 值班人员id组
        /// </summary>
        [JsonProperty("StaffInfos")]
        public StaffInfo[] StaffInfos{ get; set; }

        /// <summary>
        /// 轮转类型
        /// </summary>
        [JsonProperty("RotationType")]
        public string RotationType{ get; set; }

        /// <summary>
        /// 换班时间
        /// </summary>
        [JsonProperty("ShiftTime")]
        public string ShiftTime{ get; set; }

        /// <summary>
        /// 有效期开始时间，单位s
        /// </summary>
        [JsonProperty("EffectiveStartTime")]
        public long? EffectiveStartTime{ get; set; }

        /// <summary>
        /// 有效期结束时间，单位s
        /// </summary>
        [JsonProperty("EffectiveEndTime")]
        public long? EffectiveEndTime{ get; set; }

        /// <summary>
        /// 时区(-12 - 12)
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// 值班表描述
        /// </summary>
        [JsonProperty("OnCallFormDesc")]
        public string OnCallFormDesc{ get; set; }

        /// <summary>
        /// 轮班信息
        /// </summary>
        [JsonProperty("CoverStaffInfos")]
        public CoverStaffInfo[] CoverStaffInfos{ get; set; }

        /// <summary>
        /// 模板绑定的标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "OnCallFormName", this.OnCallFormName);
            this.SetParamArrayObj(map, prefix + "StaffInfos.", this.StaffInfos);
            this.SetParamSimple(map, prefix + "RotationType", this.RotationType);
            this.SetParamSimple(map, prefix + "ShiftTime", this.ShiftTime);
            this.SetParamSimple(map, prefix + "EffectiveStartTime", this.EffectiveStartTime);
            this.SetParamSimple(map, prefix + "EffectiveEndTime", this.EffectiveEndTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "OnCallFormDesc", this.OnCallFormDesc);
            this.SetParamArrayObj(map, prefix + "CoverStaffInfos.", this.CoverStaffInfos);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}


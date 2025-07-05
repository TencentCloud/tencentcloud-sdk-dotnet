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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreReleaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 预订倒计时(YYYY-MM-DD hh:mm:ss)
        /// </summary>
        [JsonProperty("ReservationTime")]
        public string ReservationTime{ get; set; }

        /// <summary>
        /// 域名注册时间(YYYY-MM-DD hh:mm:ss)
        /// </summary>
        [JsonProperty("RegTime")]
        public string RegTime{ get; set; }

        /// <summary>
        /// 域名删除时间(YYYY-MM-DD hh:mm:ss)
        /// </summary>
        [JsonProperty("DelTime")]
        public string DelTime{ get; set; }

        /// <summary>
        /// 当前人数
        /// </summary>
        [JsonProperty("CurrentPeople")]
        public long? CurrentPeople{ get; set; }

        /// <summary>
        /// 当前价格
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// 是否收藏
        /// true：收藏
        /// false：未收藏
        /// </summary>
        [JsonProperty("IsFollow")]
        public bool? IsFollow{ get; set; }

        /// <summary>
        /// 是否已经预约
        /// true：预约
        /// false：未预约
        /// </summary>
        [JsonProperty("IsAppoint")]
        public bool? IsAppoint{ get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 是否为原持有者
        /// true：是原持有人
        /// false：非原持有人
        /// </summary>
        [JsonProperty("IsDomainUser")]
        public bool? IsDomainUser{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ReservationTime", this.ReservationTime);
            this.SetParamSimple(map, prefix + "RegTime", this.RegTime);
            this.SetParamSimple(map, prefix + "DelTime", this.DelTime);
            this.SetParamSimple(map, prefix + "CurrentPeople", this.CurrentPeople);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "IsFollow", this.IsFollow);
            this.SetParamSimple(map, prefix + "IsAppoint", this.IsAppoint);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "IsDomainUser", this.IsDomainUser);
        }
    }
}


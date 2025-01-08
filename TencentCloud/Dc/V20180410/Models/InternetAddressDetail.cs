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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAddressDetail : AbstractModel
    {
        
        /// <summary>
        /// 互联网地址ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 互联网网络地址
        /// </summary>
        [JsonProperty("Subnet")]
        public string Subnet{ get; set; }

        /// <summary>
        /// 网络地址掩码长度
        /// </summary>
        [JsonProperty("MaskLen")]
        public long? MaskLen{ get; set; }

        /// <summary>
        /// 0:BGP
        /// 1:电信
        /// 2:移动
        /// 3:联通
        /// </summary>
        [JsonProperty("AddrType")]
        public long? AddrType{ get; set; }

        /// <summary>
        /// 0:使用中
        /// 1:已停用
        /// 2:已退还
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// 停用时间
        /// </summary>
        [JsonProperty("StopTime")]
        public string StopTime{ get; set; }

        /// <summary>
        /// 退还时间
        /// </summary>
        [JsonProperty("ReleaseTime")]
        public string ReleaseTime{ get; set; }

        /// <summary>
        /// 地域信息
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 0:IPv4 1:IPv6
        /// </summary>
        [JsonProperty("AddrProto")]
        public long? AddrProto{ get; set; }

        /// <summary>
        /// 释放状态的IP地址保留的天数
        /// </summary>
        [JsonProperty("ReserveTime")]
        public long? ReserveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Subnet", this.Subnet);
            this.SetParamSimple(map, prefix + "MaskLen", this.MaskLen);
            this.SetParamSimple(map, prefix + "AddrType", this.AddrType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamSimple(map, prefix + "ReleaseTime", this.ReleaseTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AddrProto", this.AddrProto);
            this.SetParamSimple(map, prefix + "ReserveTime", this.ReserveTime);
        }
    }
}


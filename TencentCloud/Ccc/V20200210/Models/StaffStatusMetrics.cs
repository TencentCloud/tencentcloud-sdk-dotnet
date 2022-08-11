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

    public class StaffStatusMetrics : AbstractModel
    {
        
        /// <summary>
        /// 坐席邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 坐席状态 free 示闲 | busy 忙碌 | rest 小休 | notReady 示忙 | afterCallWork 话后调整 | offline 离线
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 坐席状态补充信息
        /// </summary>
        [JsonProperty("StatusExtra")]
        public StaffStatusExtra StatusExtra{ get; set; }

        /// <summary>
        /// 当天在线总时长
        /// </summary>
        [JsonProperty("OnlineDuration")]
        public long? OnlineDuration{ get; set; }

        /// <summary>
        /// 当天示闲总时长
        /// </summary>
        [JsonProperty("FreeDuration")]
        public long? FreeDuration{ get; set; }

        /// <summary>
        /// 当天忙碌总时长
        /// </summary>
        [JsonProperty("BusyDuration")]
        public long? BusyDuration{ get; set; }

        /// <summary>
        /// 当天示忙总时长
        /// </summary>
        [JsonProperty("NotReadyDuration")]
        public long? NotReadyDuration{ get; set; }

        /// <summary>
        /// 当天小休总时长
        /// </summary>
        [JsonProperty("RestDuration")]
        public long? RestDuration{ get; set; }

        /// <summary>
        /// 当天话后调整总时长
        /// </summary>
        [JsonProperty("AfterCallWorkDuration")]
        public long? AfterCallWorkDuration{ get; set; }

        /// <summary>
        /// 小休原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 是否预约小休
        /// </summary>
        [JsonProperty("ReserveRest")]
        public bool? ReserveRest{ get; set; }

        /// <summary>
        /// 是否预约示忙
        /// </summary>
        [JsonProperty("ReserveNotReady")]
        public bool? ReserveNotReady{ get; set; }

        /// <summary>
        /// 手机接听模式： 0 - 关闭 | 1 - 仅离线 | 2- 始终
        /// </summary>
        [JsonProperty("UseMobileAccept")]
        public long? UseMobileAccept{ get; set; }

        /// <summary>
        /// 手机外呼开关
        /// </summary>
        [JsonProperty("UseMobileCallOut")]
        public bool? UseMobileCallOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "StatusExtra.", this.StatusExtra);
            this.SetParamSimple(map, prefix + "OnlineDuration", this.OnlineDuration);
            this.SetParamSimple(map, prefix + "FreeDuration", this.FreeDuration);
            this.SetParamSimple(map, prefix + "BusyDuration", this.BusyDuration);
            this.SetParamSimple(map, prefix + "NotReadyDuration", this.NotReadyDuration);
            this.SetParamSimple(map, prefix + "RestDuration", this.RestDuration);
            this.SetParamSimple(map, prefix + "AfterCallWorkDuration", this.AfterCallWorkDuration);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "ReserveRest", this.ReserveRest);
            this.SetParamSimple(map, prefix + "ReserveNotReady", this.ReserveNotReady);
            this.SetParamSimple(map, prefix + "UseMobileAccept", this.UseMobileAccept);
            this.SetParamSimple(map, prefix + "UseMobileCallOut", this.UseMobileCallOut);
        }
    }
}


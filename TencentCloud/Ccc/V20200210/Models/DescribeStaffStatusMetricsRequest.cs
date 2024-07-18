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

    public class DescribeStaffStatusMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 筛选坐席列表，默认不传返回全部坐席信息
        /// </summary>
        [JsonProperty("StaffList")]
        public string[] StaffList{ get; set; }

        /// <summary>
        /// 筛选技能组ID列表
        /// </summary>
        [JsonProperty("GroupIdList")]
        public long?[] GroupIdList{ get; set; }

        /// <summary>
        /// 筛选坐席状态列表 座席状态 free 示闲 | busy 忙碌 | rest 小休 | notReady 示忙 | afterCallWork 话后调整 | offline 离线 
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "StaffList.", this.StaffList);
            this.SetParamArraySimple(map, prefix + "GroupIdList.", this.GroupIdList);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
        }
    }
}


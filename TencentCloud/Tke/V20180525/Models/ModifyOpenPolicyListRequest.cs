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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyOpenPolicyListRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，请从容器服务集群控制台获取（https://console.cloud.tencent.com/tke2/cluster）。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 修改的策略列表，目前仅支持修改EnforcementAction字段
        /// </summary>
        [JsonProperty("OpenPolicyInfoList")]
        public OpenPolicySwitch[] OpenPolicyInfoList{ get; set; }

        /// <summary>
        /// 策略分类 基线：baseline 优选：priority 可选：optional
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "OpenPolicyInfoList.", this.OpenPolicyInfoList);
            this.SetParamSimple(map, prefix + "Category", this.Category);
        }
    }
}


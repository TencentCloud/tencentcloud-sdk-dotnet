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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachedPolicyOfRole : AbstractModel
    {
        
        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 绑定时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 策略类型，User表示自定义策略，QCS表示预设策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 策略创建方式，1表示按产品功能或项目权限创建，其他表示按策略语法创建
        /// </summary>
        [JsonProperty("CreateMode")]
        public ulong? CreateMode{ get; set; }

        /// <summary>
        /// 是否已下线(0:否 1:是)
        /// </summary>
        [JsonProperty("Deactived")]
        public ulong? Deactived{ get; set; }

        /// <summary>
        /// 已下线的产品列表
        /// </summary>
        [JsonProperty("DeactivedDetail")]
        public string[] DeactivedDetail{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "CreateMode", this.CreateMode);
            this.SetParamSimple(map, prefix + "Deactived", this.Deactived);
            this.SetParamArraySimple(map, prefix + "DeactivedDetail.", this.DeactivedDetail);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}


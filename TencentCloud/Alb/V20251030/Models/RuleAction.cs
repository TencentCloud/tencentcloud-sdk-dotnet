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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleAction : AbstractModel
    {
        
        /// <summary>
        /// 转发动作执行顺序，不能重复，按从小到大顺序执行。取值范围：1 ~ 50000。
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// 转发动作类型。取值：
        /// TargetGroup：转发至目标组。
        /// Redirect：重定向。
        /// FixedResponse：返回固定内容。
        /// Rewrite：重写。
        /// InsertHeader：写入HTTP Header。
        /// RemoveHeader：删除HTTP Header。
        /// 转发动作必选包含TargetGroup,Redirect,FixedResponse其中一个，并且执行顺序放在最后。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 固定响应内容配置。
        /// </summary>
        [JsonProperty("FixedResponseConfig")]
        public FixedResponseInfo FixedResponseConfig{ get; set; }

        /// <summary>
        /// 插入HTTP Header配置。
        /// </summary>
        [JsonProperty("InsertHeaderConfig")]
        public InsertHTTPHeaderInfo InsertHeaderConfig{ get; set; }

        /// <summary>
        /// 重定向配置。除HttpCode外，其他配置不能都使用默认值。
        /// </summary>
        [JsonProperty("RedirectConfig")]
        public HTTPRedirectInfo RedirectConfig{ get; set; }

        /// <summary>
        /// 删除HTTP Header配置。
        /// </summary>
        [JsonProperty("RemoveHeaderConfig")]
        public RemoveHTTPHeaderInfo RemoveHeaderConfig{ get; set; }

        /// <summary>
        /// 重写配置。
        /// </summary>
        [JsonProperty("RewriteConfig")]
        public HTTPRewriteInfo RewriteConfig{ get; set; }

        /// <summary>
        /// 转发目标组配置。
        /// </summary>
        [JsonProperty("TargetGroupConfig")]
        public TargetGroupConfig TargetGroupConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "FixedResponseConfig.", this.FixedResponseConfig);
            this.SetParamObj(map, prefix + "InsertHeaderConfig.", this.InsertHeaderConfig);
            this.SetParamObj(map, prefix + "RedirectConfig.", this.RedirectConfig);
            this.SetParamObj(map, prefix + "RemoveHeaderConfig.", this.RemoveHeaderConfig);
            this.SetParamObj(map, prefix + "RewriteConfig.", this.RewriteConfig);
            this.SetParamObj(map, prefix + "TargetGroupConfig.", this.TargetGroupConfig);
        }
    }
}


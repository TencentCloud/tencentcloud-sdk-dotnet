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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotRecord : AbstractModel
    {
        
        /// <summary>
        /// 动作，取值为以为3个类型中的一个："intercept","permit","monitor"，分别表示： 拦截， 放行，监控
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 会话总次数
        /// </summary>
        [JsonProperty("Nums")]
        public long? Nums{ get; set; }

        /// <summary>
        /// BotType=UB时，表示预测标签，取值如下：
        ///                 "crawler_unregular",
        ///                 "crawler_regular",
        ///                 "request_repeat",
        ///                 "credential_miss_user",
        ///                 "credential_without_user",
        ///                 "credential_only_action",
        ///                 "credential_user_password",
        ///                 "credential_cracking",
        ///                 "credential_stuffing",
        ///                 "brush_sms",
        ///                 "brush_captcha",
        ///                 "reg_malicious"
        /// BotType=TCB时，表示Bot分类，取值如下：
        ///                 "Uncategorised",
        ///                 "Search engine bot",
        ///                 "Site monitor",
        ///                 "Screenshot creator",
        ///                 "Link checker",
        ///                 "Web scraper",
        ///                 "Vulnerability scanner",
        ///                 "Virus scanner",
        ///                 "Speed tester",
        ///                 "Feed Fetcher",
        ///                 "Tool",
        ///                 "Marketing"
        /// BotType=UCB时，为二期接口，暂时未定义内容
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 会话持续时间
        /// </summary>
        [JsonProperty("SessionDuration")]
        public float? SessionDuration{ get; set; }

        /// <summary>
        /// 访问源IP
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 异常特征
        /// </summary>
        [JsonProperty("BotFeature")]
        public string[] BotFeature{ get; set; }

        /// <summary>
        /// 最新检测时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// BOT得分
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 平均速率
        /// </summary>
        [JsonProperty("AvgSpeed")]
        public float? AvgSpeed{ get; set; }

        /// <summary>
        /// BotType=TCB，表示TCB名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcbDetail")]
        public string TcbDetail{ get; set; }

        /// <summary>
        /// BOT记录唯一ID，用于查询访问详情
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Nums", this.Nums);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "SessionDuration", this.SessionDuration);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamArraySimple(map, prefix + "BotFeature.", this.BotFeature);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "AvgSpeed", this.AvgSpeed);
            this.SetParamSimple(map, prefix + "TcbDetail", this.TcbDetail);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}


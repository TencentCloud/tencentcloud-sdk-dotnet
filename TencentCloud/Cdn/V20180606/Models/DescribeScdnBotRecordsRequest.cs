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

    public class DescribeScdnBotRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// BOT类型，取值为"UB","UCB","TCB"，分别表示：未知类型，自定义类型，公开类型
        /// </summary>
        [JsonProperty("BotType")]
        public string BotType{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// mainland 大陆地区 overseas境外地区
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("SortBy")]
        public BotSortBy[] SortBy{ get; set; }

        /// <summary>
        /// BotType=UB时，表示需要过滤的预测标签，取值如下：
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
        /// BotType=TCB时，表示需要过滤的Bot分类，取值如下：
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
        /// BotType=UCB时，取值如下：
        /// User-Agent为空或不存在
        /// User-Agent类型为BOT
        /// User-Agent类型为HTTP Library
        /// User-Agent类型为Framework
        /// User-Agent类型为Tools
        /// User-Agent类型为Unkonwn BOT
        /// User-Agent类型为Scanner
        /// Referer空或不存在
        /// Referer滥用(多个UA使用相同Referer)
        /// Cookie滥用(多个UA使用相同Cookie)
        /// Cookie空或不存在
        /// Connection空或不存在
        /// Accept空或不存在
        /// Accept-Language空或不存在
        /// Accept-Enconding空或不存在
        /// 使用HTTP HEAD方法
        /// HTTP协议为1.0或者更低
        /// IDC-IP 腾讯云
        /// IDC-IP 阿里云
        /// IDC-IP 华为云
        /// IDC-IP 金山云
        /// IDC-IP UCloud
        /// IDC-IP 百度云
        /// IDC-IP 京东云
        /// IDC-IP 青云
        /// IDC-IP Aws
        /// IDC-IP Azure
        /// IDC-IP Google
        /// 
        /// 以上所有类型，FilterName为空时，表示不过滤，获取所有内容
        /// </summary>
        [JsonProperty("FilterName")]
        public string FilterName{ get; set; }

        /// <summary>
        /// 目前支持的Action
        /// "intercept" 拦截
        /// "monitor"，监控
        /// "permit" 放行
        /// "redirect" 重定向
        /// 
        /// 尚未支持的Action
        /// "captcha" 验证码
        /// </summary>
        [JsonProperty("FilterAction")]
        public string FilterAction{ get; set; }

        /// <summary>
        /// 过滤的IP
        /// </summary>
        [JsonProperty("FilterIp")]
        public string FilterIp{ get; set; }

        /// <summary>
        /// 域名列表，为空表示查询AppID维度数据
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotType", this.BotType);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "SortBy.", this.SortBy);
            this.SetParamSimple(map, prefix + "FilterName", this.FilterName);
            this.SetParamSimple(map, prefix + "FilterAction", this.FilterAction);
            this.SetParamSimple(map, prefix + "FilterIp", this.FilterIp);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
        }
    }
}


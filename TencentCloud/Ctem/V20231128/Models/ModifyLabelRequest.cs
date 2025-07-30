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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块，包括：enterprise：企业架构，domain：主域名，sub_domain：子域名，asset：IP资产，port：端口服务，http：HTTP资产，vul：漏洞信息，app：APP，wechat_applet：微信小程序，wechat_official_account：微信公众号，github：Github信息泄露，manage：管理后台暴露，config：目录爆破，dark_web：暗网泄露，net_disk：文库网盘泄露，supply_chain：供应链，weak_password：弱口令，sensitive_info：敏感信息泄露
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 企业ID列表，可多选
        /// </summary>
        [JsonProperty("CustomerIdList")]
        public long?[] CustomerIdList{ get; set; }

        /// <summary>
        /// 资产或风险主键ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 企业ID，在企业管理页面查看
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// 是否聚合数据
        /// </summary>
        [JsonProperty("IsAggregation")]
        public bool? IsAggregation{ get; set; }

        /// <summary>
        /// 标签详情
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// 资产或风险主键ID列表
        /// </summary>
        [JsonProperty("Ids")]
        public long?[] Ids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamArraySimple(map, prefix + "CustomerIdList.", this.CustomerIdList);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "IsAggregation", this.IsAggregation);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
        }
    }
}


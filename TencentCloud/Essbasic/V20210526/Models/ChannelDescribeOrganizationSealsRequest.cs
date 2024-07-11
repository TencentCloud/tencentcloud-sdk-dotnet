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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelDescribeOrganizationSealsRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 指定分页每页返回的数据条数，单页最大支持 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页查询偏移量，默认为0，最大为20000
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询授权用户信息类型，取值如下：
        /// 
        /// <ul> <li><b>0</b>：（默认）不返回授权用户信息</li> <li><b>1</b>：返回授权用户的信息</li> </ul>
        /// </summary>
        [JsonProperty("InfoType")]
        public long? InfoType{ get; set; }

        /// <summary>
        /// 印章id，是否查询特定的印章（没有输入返回所有）
        /// 
        /// 注:  `没有输入返回所有记录，最大返回100条。`
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 电子印章类型 , 可选类型如下: <ul><li>**OFFICIAL**: 公章</li><li>**CONTRACT**: 合同专用章;</li><li>**FINANCE**: 财务专用章;</li><li>**PERSONNEL**: 人事专用章</li><li>**INVOICE**: 发票专用章</li><<li>**EMPLOYEE_QUALIFICATION_SEAL**: 员工执业章</li></ul>注:  `为空时查询所有类型的印章。`
        /// </summary>
        [JsonProperty("SealTypes")]
        public string[] SealTypes{ get; set; }

        /// <summary>
        /// 
        /// 需查询的印章状态列表。
        /// 
        /// <ul> <li>空，()仅查询启用状态的印章；</li> <li><strong>ALL</strong>，查询所有状态的印章；</li> <li><strong>CHECKING</strong>，查询待审核的印章；</li> <li><strong>SUCCESS</strong>，查询启用状态的印章；</li> <li><strong>FAIL</strong>，查询印章审核拒绝的印章；</li> <li><strong>DISABLE</strong>，查询已停用的印章；</li> <li><strong>STOPPED</strong>，查询已终止的印章；</li> <li><strong>VOID</strong>，查询已作废的印章；</li> <li><strong>INVALID</strong>，查询已失效的印章。</li> </ul>
        /// </summary>
        [JsonProperty("SealStatuses")]
        public string[] SealStatuses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamArraySimple(map, prefix + "SealTypes.", this.SealTypes);
            this.SetParamArraySimple(map, prefix + "SealStatuses.", this.SealStatuses);
        }
    }
}


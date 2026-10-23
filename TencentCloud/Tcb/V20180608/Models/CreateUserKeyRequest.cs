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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>用户创建的集成名称，或者密钥名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>用户创建的集成ID，集成表示，或者密钥对标识，前半部分用户填写，后半部分平台按照一定规则生成</p>
        /// </summary>
        [JsonProperty("KeyID")]
        public string KeyID{ get; set; }

        /// <summary>
        /// <p>集成描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>集成类型，或者授权类型码，对应GetUserKeyTemplateList接口的AuthTypeCode字段，比如github、gitlab、gitee、meeting、PublicAccountOpenService等</p>
        /// </summary>
        [JsonProperty("AuthTypeCode")]
        public string AuthTypeCode{ get; set; }

        /// <summary>
        /// <p>根据集成类型的不同，ext会有不同的子结构，具体每种授权类型的ext需要填写的信息，可以通过GetUserKeyTemplateList获取</p>
        /// </summary>
        [JsonProperty("Ext")]
        public string Ext{ get; set; }

        /// <summary>
        /// <p>github、gitlab、gitee、腾讯会议等oauth类型的，需要传这个ticket_id，创建的密钥对跟auth_ticket_token(对于github、gitlab、gitee)、weda_ticket_token(对于腾讯会议)关联起来</p>
        /// </summary>
        [JsonProperty("TicketID")]
        public string TicketID{ get; set; }

        /// <summary>
        /// <p>业务类型，integration：从集成中心来的，默认为空，表示是从授权管理中心来的</p>
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// <p>创建demo代码云函数需要的参数信息</p><p>入参限制：当Business为integration，且AuthTypeCode为(weixinmp、wxvirtualpay、weixin-store、channels、weixinpaydc)之一时必填</p>
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public AgentRuntimeConfig RuntimeConfig{ get; set; }

        /// <summary>
        /// <p>创建集成时创建关联的示例代码云函数的名称，当Business为integration，且AuthTypeCode为(weixinmp、wxvirtualpay、weixin-store、channels、weixinpaydc)之一时必填</p>
        /// </summary>
        [JsonProperty("DemoCodeFunctionName")]
        public string DemoCodeFunctionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KeyID", this.KeyID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AuthTypeCode", this.AuthTypeCode);
            this.SetParamSimple(map, prefix + "Ext", this.Ext);
            this.SetParamSimple(map, prefix + "TicketID", this.TicketID);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
            this.SetParamSimple(map, prefix + "DemoCodeFunctionName", this.DemoCodeFunctionName);
        }
    }
}


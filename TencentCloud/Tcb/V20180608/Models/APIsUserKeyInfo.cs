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

    public class APIsUserKeyInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>用户创建的集成的名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>用户对创建的集成的描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>集成ID，用户创建的集成的标识id，前半部分用户填写，后半部分平台按照一定规则生成</p>
        /// </summary>
        [JsonProperty("KeyID")]
        public string KeyID{ get; set; }

        /// <summary>
        /// <p>额外信息,根据集成类型不同，ext会有不同的子结构</p>
        /// </summary>
        [JsonProperty("Ext")]
        public string Ext{ get; set; }

        /// <summary>
        /// <p>集成类型Code</p>
        /// </summary>
        [JsonProperty("AuthTypeCode")]
        public string AuthTypeCode{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>引用该集成的服务列表</p>
        /// </summary>
        [JsonProperty("BindServiceList")]
        public BindServiceList BindServiceList{ get; set; }

        /// <summary>
        /// <p>AuthTypeName 和AuthType 分别1-1对应</p>
        /// </summary>
        [JsonProperty("AuthTypeName")]
        public string AuthTypeName{ get; set; }

        /// <summary>
        /// <p>github、gitlab、gitee、腾讯会议等oauth类型的，需要传这个ticket_id，创建的密钥对跟auth_ticket_token(对于github、gitlab、gitee)、weda_ticket_token(对于腾讯会议)关联起来</p>
        /// </summary>
        [JsonProperty("TicketID")]
        public string TicketID{ get; set; }

        /// <summary>
        /// <p>用户在创建(weixinmp、wxvirtualpay、weixin-store、channels、weixinpaydc)这五种之一时创建的关联的示例代码云函数的函数名</p>
        /// </summary>
        [JsonProperty("DemoCodeFunctionName")]
        public string DemoCodeFunctionName{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：2026-05-25T11:18:28+08:00</p>
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：2026-05-25T11:18:28+08:00</p>
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyID", this.KeyID);
            this.SetParamSimple(map, prefix + "Ext", this.Ext);
            this.SetParamSimple(map, prefix + "AuthTypeCode", this.AuthTypeCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "BindServiceList.", this.BindServiceList);
            this.SetParamSimple(map, prefix + "AuthTypeName", this.AuthTypeName);
            this.SetParamSimple(map, prefix + "TicketID", this.TicketID);
            this.SetParamSimple(map, prefix + "DemoCodeFunctionName", this.DemoCodeFunctionName);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
        }
    }
}


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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSchemeUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 姓名,最大长度50个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 手机号，大陆手机号11位
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 要跳转的链接类型
        /// 
        /// - HTTP：跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型  (默认)，此时返回长链
        /// - HTTP_SHORT_URL：跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型，此时返回短链
        /// - APP： 第三方APP或小程序跳转电子签小程序的path,  APP或者小程序跳转适合此类型
        /// </summary>
        [JsonProperty("EndPoint")]
        public string EndPoint{ get; set; }

        /// <summary>
        /// 签署流程编号 (PathType=1时必传)
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同组ID 
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// 要跳转到的页面类型 
        /// 
        /// - 0: 不传, 主页 (默认)
        /// - 1: 小程序合同详情 
        /// - 2: 小程序合同列表页 
        /// </summary>
        [JsonProperty("PathType")]
        public ulong? PathType{ get; set; }

        /// <summary>
        /// 是否自动回跳
        /// true：是，
        /// false：否。
        /// 该参数只针对"APP" 类型的签署链接有效
        /// </summary>
        [JsonProperty("AutoJumpBack")]
        public bool? AutoJumpBack{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 生成的签署链接在签署过程隐藏的按钮列表, 可以设置隐藏的按钮列表如下
        /// 
        /// - 0:合同签署页面更多操作按钮
        /// - 1:合同签署页面更多操作的拒绝签署按钮
        /// - 2:合同签署页面更多操作的转他人处理按钮
        /// - 3:签署成功页的查看详情按钮
        /// </summary>
        [JsonProperty("Hides")]
        public long?[] Hides{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "EndPoint", this.EndPoint);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "PathType", this.PathType);
            this.SetParamSimple(map, prefix + "AutoJumpBack", this.AutoJumpBack);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "Hides.", this.Hides);
        }
    }
}


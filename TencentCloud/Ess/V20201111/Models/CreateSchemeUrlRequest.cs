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
        /// 调用方用户信息，参考通用结构
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 应用相关信息
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 链接类型
        /// HTTP：跳转电子签小程序的http_url，
        /// APP：第三方APP或小程序跳转电子签小程序的path。
        /// 默认为HTTP类型
        /// </summary>
        [JsonProperty("EndPoint")]
        public string EndPoint{ get; set; }

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
        /// 企业名称
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 签署流程编号 (PathType=1时必传)
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 跳转页面 1: 小程序合同详情 2: 小程序合同列表页 0: 不传, 默认主页
        /// </summary>
        [JsonProperty("PathType")]
        public ulong? PathType{ get; set; }

        /// <summary>
        /// 是否自动回跳 true：是， false：否。该参数只针对"APP" 类型的签署链接有效
        /// </summary>
        [JsonProperty("AutoJumpBack")]
        public bool? AutoJumpBack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "EndPoint", this.EndPoint);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "PathType", this.PathType);
            this.SetParamSimple(map, prefix + "AutoJumpBack", this.AutoJumpBack);
        }
    }
}


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

    public class CreateUserNameChangeUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 要跳转的链接类型
        /// 
        /// <ul>
        /// <li><strong>HTTP</strong>：适用于短信通知或H5跳转的电子签小程序HTTP长链接</li>
        /// <li><strong>HTTP_SHORT_URL</strong>：适用于短信通知或H5跳转的电子签小程序HTTP短链接</li>
        /// <li><strong>APP</strong>：（默认类型）适用于第三方APP或小程序跳转的电子签小程序路径</li>
        /// </ul>
        /// 
        /// 注：如果不传递，默认值是 <font color="red"> HTTP </font>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 在用户完成改名后，其自定义数据将通过[企业引导个人更名后回调](https://qian.tencent.com/developers/company/callback_types_staffs#%E5%8D%81%E5%85%AB-%E4%BC%81%E4%B8%9A%E5%BC%95%E5%AF%BC%E4%B8%AA%E4%BA%BA%E6%9B%B4%E5%90%8D%E5%90%8E%E5%9B%9E%E8%B0%83)返回，以便用户确认其个人数据信息。请注意，自定义数据的字符长度上限为1000，且必须采用base64编码格式。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
        }
    }
}


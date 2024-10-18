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

    public class CreateConsoleLoginUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 跳转链接, 链接的有效期根据企业,员工状态和终端等有区别, 可以参考下表
        /// <table> <thead> <tr> <th>子客企业状态</th> <th>子客企业员工状态</th> <th>Endpoint</th> <th>链接有效期限</th> </tr> </thead>  <tbody> <tr> <td>企业未激活</td> <td>员工未认证</td> <td>PC/PC_SHORT_URL</td> <td>5分钟</td>  </tr>  <tr> <td>企业未激活</td> <td>员工未认证</td> <td>CHANNEL/APP/H5/SHORT_H5/WEIXIN_QRCODE_URL</td> <td>30天</td>  </tr>  <tr> <td>企业已激活</td> <td>员工未认证</td> <td>PC/PC_SHORT_URL</td> <td>5分钟</td>  </tr> <tr> <td>企业已激活</td> <td>员工未认证</td> <td>CHANNEL/APP/H5/SHORT_H5/WEIXIN_QRCODE_URL</td> <td>30天</td>  </tr>  <tr> <td>企业已激活</td> <td>员工已认证</td> <td>PC</td> <td>5分钟</td>  </tr>  <tr> <td>企业已激活</td> <td>员工已认证</td> <td>CHANNEL/APP/H5/SHORT_H5/WEIXIN_QRCODE_URL</td> <td>30天</td>  </tr> </tbody> </table>
        /// 
        /// 注： 
        /// 1. <font color="red">链接仅单次有效</font>，每次登录需要需要重新创建新的链接
        /// 2. 创建的链接应避免被转义，如：&被转义为\u0026；如使用Postman请求后，请选择响应类型为 JSON，否则链接将被转义
        /// 3. <font color="red">生成的链路后面不能再增加参数</font>（会出现覆盖链接中已有参数导致错误）
        /// </summary>
        [JsonProperty("ConsoleUrl")]
        public string ConsoleUrl{ get; set; }

        /// <summary>
        /// 子客企业是否已开通腾讯电子签，
        /// <ul><li> **true** :已经开通腾讯电子签</li>
        /// <li> **false** :还未开通腾讯电子签</li></ul>
        /// 
        /// 注：`企业是否实名根据传参Agent.ProxyOrganizationOpenId进行判断，非企业名称或者社会信用代码`
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// 当前经办人是否已认证并加入功能
        /// <ul><li> **true** : 已经认证加入公司</li>
        /// <li> **false** : 还未认证加入公司</li></ul>
        /// 注意：**员工是否实名是根据Agent.ProxyOperator.OpenId判断，非经办人姓名**
        /// </summary>
        [JsonProperty("ProxyOperatorIsVerified")]
        public bool? ProxyOperatorIsVerified{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleUrl", this.ConsoleUrl);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "ProxyOperatorIsVerified", this.ProxyOperatorIsVerified);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


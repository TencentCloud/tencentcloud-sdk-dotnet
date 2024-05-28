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

    public class ProxyOrganizationOperator : AbstractModel
    {
        
        /// <summary>
        /// 员工的唯一标识(即OpenId),  定义Agent中的OpenId一样, 可以参考<a href="https://qian.tencent.com/developers/partnerApis/dataTypes/#agent" target="_blank">Agent结构体</a>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 员工的姓名，最大长度50个字符
        /// 员工的姓名将用于身份认证和电子签名，请确保填写的姓名为真实姓名，而非昵称等代名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 签署方经办人的证件类型，支持以下类型
        /// <ul><li>ID_CARD : 中国大陆居民身份证  (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 经办人证件号
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 员工的手机号，支持国内手机号11位数字(无需加+86前缀或其他字符)，不支持海外手机号。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 预先分配员工的角色, 可以分配的角色如下:
        /// <table> <thead> <tr> <th>可以分配的角色</th> <th>角色名称</th> <th>角色描述</th> </tr> </thead> <tbody> <tr> <td>admin</td> <td>业务管理员（IT 系统负责人，e.g. CTO）</td> <td>有企业合同模块、印章模块、模板模块等全量功能及数据权限。</td> </tr> <tr> <td>channel-normal-operator</td> <td>经办人（企业法务负责人）</td> <td>有发起合同、签署合同（含填写、拒签）、撤销合同、持有印章等权限能力，可查看企业所有合同数据。</td> </tr> <tr> <td>channel-sales-man</td> <td>业务员（一般为销售员、采购员）</td> <td>有发起合同、签署合同（含填写、拒签）、撤销合同、持有印章等权限能力，可查看自己相关所有合同数据。</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("DefaultRole")]
        public string DefaultRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "DefaultRole", this.DefaultRole);
        }
    }
}


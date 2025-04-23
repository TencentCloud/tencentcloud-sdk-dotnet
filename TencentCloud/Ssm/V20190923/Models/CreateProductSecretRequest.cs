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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProductSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// 凭据名称，同一region内不可重复，最长128字节，使用字母、数字或者 - _ 的组合，第一个字符必须为字母或者数字。
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 用户账号名前缀，由用户自行指定，长度限定在8个字符以内，
        /// 可选字符集包括：
        /// 数字字符：[0, 9]，
        /// 小写字符：[a, z]，
        /// 大写字符：[A, Z]，
        /// 特殊字符(全英文符号)：下划线(_)，
        /// 前缀必须以大写或小写字母开头。
        /// </summary>
        [JsonProperty("UserNamePrefix")]
        public string UserNamePrefix{ get; set; }

        /// <summary>
        /// 凭据所绑定的云产品名称，如Mysql，可以通过DescribeSupportedProducts接口获取所支持的云产品名称。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 云产品实例ID。
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 账号的域名，IP形式，支持填入%。
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 将凭据与云产品实例绑定时，需要授予的权限列表。
        /// </summary>
        [JsonProperty("PrivilegesList")]
        public ProductPrivilegeUnit[] PrivilegesList{ get; set; }

        /// <summary>
        /// 描述信息，用于详细描述用途等，最大支持2048字节。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 指定对凭据进行加密的KMS CMK。
        /// 如果为空则表示使用Secrets Manager为您默认创建的CMK进行加密。
        /// 您也可以指定在同region 下自行创建的KMS CMK进行加密。
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 用户自定义的开始轮转时间，格式：2006-01-02 15:04:05。
        /// 当EnableRotation为True时，此参数必填。
        /// </summary>
        [JsonProperty("RotationBeginTime")]
        public string RotationBeginTime{ get; set; }

        /// <summary>
        /// 是否开启轮转
        /// True -- 开启
        /// False -- 不开启
        /// 如果不指定，默认为False。
        /// </summary>
        [JsonProperty("EnableRotation")]
        public bool? EnableRotation{ get; set; }

        /// <summary>
        /// 轮转周期，以天为单位，默认为1天。
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }

        /// <summary>
        /// KMS的独享集群的ID。当KmsKeyId为空,并且用户的KMS存在有效的HsmClusterId时有效。
        /// </summary>
        [JsonProperty("KmsHsmClusterId")]
        public string KmsHsmClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "UserNamePrefix", this.UserNamePrefix);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArrayObj(map, prefix + "PrivilegesList.", this.PrivilegesList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RotationBeginTime", this.RotationBeginTime);
            this.SetParamSimple(map, prefix + "EnableRotation", this.EnableRotation);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
            this.SetParamSimple(map, prefix + "KmsHsmClusterId", this.KmsHsmClusterId);
        }
    }
}


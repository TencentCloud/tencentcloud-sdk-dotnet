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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecretResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>凭据名称。</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>凭据描述信息。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>用于加密的KMS CMK ID。</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>创建者UIN。</p>
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// <p>凭据状态：Enabled、Disabled、PendingDelete, Creating, Failed。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>删除日期，uinx 时间戳，非计划删除状态的凭据为0。</p>
        /// </summary>
        [JsonProperty("DeleteTime")]
        public ulong? DeleteTime{ get; set; }

        /// <summary>
        /// <p>创建日期。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>0 --  用户自定义凭据类型；1 -- 数据库凭据类型；2 -- SSH密钥对凭据类型；3 -- 云API密钥（AKSK）凭据类型（使用此功能需要联系云助手单独开启白名单）；4 -- Redis类型凭据。</p>
        /// </summary>
        [JsonProperty("SecretType")]
        public long? SecretType{ get; set; }

        /// <summary>
        /// <p>云产品名称。</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>云产品实例ID。</p>
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// <p>是否开启轮转：True -- 开启轮转；False -- 关闭轮转。</p>
        /// </summary>
        [JsonProperty("RotationStatus")]
        public bool? RotationStatus{ get; set; }

        /// <summary>
        /// <p>轮转周期，默认以天为单位。</p>
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }

        /// <summary>
        /// <p>当凭据类型为SSH密钥对凭据时，此字段有效，用于表示SSH密钥对凭据的名称。</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>当凭据类型为SSH密钥对凭据时，此字段有效，用于表示SSH密钥对所属的项目ID。</p>
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// <p>当凭据类型为SSH密钥对凭据时，此字段有效，用于表示SSH密钥对所关联的CVM实例ID。</p>
        /// </summary>
        [JsonProperty("AssociatedInstanceIDs")]
        public string[] AssociatedInstanceIDs{ get; set; }

        /// <summary>
        /// <p>当凭据类型为云API密钥对凭据时，此字段有效，用于表示此云API密钥对所属的用户UIN。</p>
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }

        /// <summary>
        /// <p>凭据额外配置</p>
        /// </summary>
        [JsonProperty("AdditionalConfig")]
        public string AdditionalConfig{ get; set; }

        /// <summary>
        /// <p>凭据加密类型</p><p>枚举值：</p><ul><li>0： KMS 密钥加密</li><li>1： 软密钥加密</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("EncryptType")]
        public ulong? EncryptType{ get; set; }

        /// <summary>
        /// <p>凭据更新状态</p>
        /// </summary>
        [JsonProperty("EncryptSwitching")]
        public bool? EncryptSwitching{ get; set; }

        /// <summary>
        /// <p>创建者 uin 字符串</p>
        /// </summary>
        [JsonProperty("CreateUinString")]
        public string CreateUinString{ get; set; }

        /// <summary>
        /// <p>所属用户UIN 字符串</p>
        /// </summary>
        [JsonProperty("TargetUinString")]
        public string TargetUinString{ get; set; }

        /// <summary>
        /// <p>对应云产品的账号信息</p>
        /// </summary>
        [JsonProperty("AccountInfoList")]
        public SecretAccountInfo[] AccountInfoList{ get; set; }

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
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "RotationStatus", this.RotationStatus);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamArraySimple(map, prefix + "AssociatedInstanceIDs.", this.AssociatedInstanceIDs);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "AdditionalConfig", this.AdditionalConfig);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "EncryptSwitching", this.EncryptSwitching);
            this.SetParamSimple(map, prefix + "CreateUinString", this.CreateUinString);
            this.SetParamSimple(map, prefix + "TargetUinString", this.TargetUinString);
            this.SetParamArrayObj(map, prefix + "AccountInfoList.", this.AccountInfoList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


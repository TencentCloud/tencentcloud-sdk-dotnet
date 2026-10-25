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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductEntry : AbstractModel
    {
        
        /// <summary>
        /// <p>产品ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>产品名称</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>产品分组模板ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// <p>加密类型。1表示证书认证，2表示密钥认证，21表示TID认证-SE方式，22表示TID认证-软加固方式</p>
        /// </summary>
        [JsonProperty("EncryptionType")]
        public string EncryptionType{ get; set; }

        /// <summary>
        /// <p>连接类型。如：<br>wifi、wifi-ble、cellular、5g、lorawan、ble、ethernet、wifi-ethernet、else、sub_zigbee、sub_ble、sub_433mhz、sub_else、sub_blemesh</p>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>数据协议 (1 使用物模型 2 为自定义类型)</p>
        /// </summary>
        [JsonProperty("DataProtocol")]
        public long? DataProtocol{ get; set; }

        /// <summary>
        /// <p>产品描述</p>
        /// </summary>
        [JsonProperty("ProductDesc")]
        public string ProductDesc{ get; set; }

        /// <summary>
        /// <p>状态 如：all 全部, dev 开发中, audit 审核中 released 已发布</p>
        /// </summary>
        [JsonProperty("DevStatus")]
        public string DevStatus{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>区域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>产品类型。如： 0 普通产品 ， 5 网关产品</p>
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>产品ModuleId</p>
        /// </summary>
        [JsonProperty("ModuleId")]
        public long? ModuleId{ get; set; }

        /// <summary>
        /// <p>是否使用脚本进行二进制转json功能 可以取值 true / false</p>
        /// </summary>
        [JsonProperty("EnableProductScript")]
        public string EnableProductScript{ get; set; }

        /// <summary>
        /// <p>创建人 UinId</p>
        /// </summary>
        [JsonProperty("CreateUserId")]
        public long? CreateUserId{ get; set; }

        /// <summary>
        /// <p>创建者昵称</p>
        /// </summary>
        [JsonProperty("CreatorNickName")]
        public string CreatorNickName{ get; set; }

        /// <summary>
        /// <p>绑定策略（1：强踢；2：非强踢；0：表示无意义）</p>
        /// </summary>
        [JsonProperty("BindStrategy")]
        public ulong? BindStrategy{ get; set; }

        /// <summary>
        /// <p>设备数量</p>
        /// </summary>
        [JsonProperty("DeviceCount")]
        public long? DeviceCount{ get; set; }

        /// <summary>
        /// <p>平均传输速率</p>
        /// </summary>
        [JsonProperty("Rate")]
        public string Rate{ get; set; }

        /// <summary>
        /// <p>有效期</p>
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// <p>互联互通标识</p>
        /// </summary>
        [JsonProperty("IsInterconnection")]
        public long? IsInterconnection{ get; set; }

        /// <summary>
        /// <p>UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>AppID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>绑定的第三方CA名称；空 = 腾讯云CA证书</p>
        /// </summary>
        [JsonProperty("PrivateCAName")]
        public string PrivateCAName{ get; set; }

        /// <summary>
        /// <p>true = 第三方CA</p>
        /// </summary>
        [JsonProperty("IsPrivateCA")]
        public bool? IsPrivateCA{ get; set; }

        /// <summary>
        /// <p>CA 证书名称</p>
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// <p>证书序列号</p>
        /// </summary>
        [JsonProperty("CertSN")]
        public string CertSN{ get; set; }

        /// <summary>
        /// <p>颁发者</p>
        /// </summary>
        [JsonProperty("IssuerName")]
        public string IssuerName{ get; set; }

        /// <summary>
        /// <p>证书主题</p>
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// <p>生效时间（Unix 秒）</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public long? EffectiveTime{ get; set; }

        /// <summary>
        /// <p>过期时间（Unix 秒）</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>CA 证书 PEM 全文</p>
        /// </summary>
        [JsonProperty("CertText")]
        public string CertText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "DataProtocol", this.DataProtocol);
            this.SetParamSimple(map, prefix + "ProductDesc", this.ProductDesc);
            this.SetParamSimple(map, prefix + "DevStatus", this.DevStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "EnableProductScript", this.EnableProductScript);
            this.SetParamSimple(map, prefix + "CreateUserId", this.CreateUserId);
            this.SetParamSimple(map, prefix + "CreatorNickName", this.CreatorNickName);
            this.SetParamSimple(map, prefix + "BindStrategy", this.BindStrategy);
            this.SetParamSimple(map, prefix + "DeviceCount", this.DeviceCount);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "IsInterconnection", this.IsInterconnection);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PrivateCAName", this.PrivateCAName);
            this.SetParamSimple(map, prefix + "IsPrivateCA", this.IsPrivateCA);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertSN", this.CertSN);
            this.SetParamSimple(map, prefix + "IssuerName", this.IssuerName);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CertText", this.CertText);
        }
    }
}


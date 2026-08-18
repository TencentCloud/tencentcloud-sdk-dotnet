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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IcebergConnectParam : AbstractModel
    {
        
        /// <summary>
        /// <p>EMR实例的HiveMetaStore节点IP</p><p>参数格式：多个使用英文分号;分隔</p><p>创建连接时必选，编辑连接时不接收该参数</p>
        /// </summary>
        [JsonProperty("ServiceVip")]
        public string ServiceVip{ get; set; }

        /// <summary>
        /// <p>EMR实例ID</p><p>创建连接时必选，编辑连接时不接收该参数</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>EMR实例的集群网络vpcId</p><p>创建连接时必选，编辑连接时不接收该参数</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>认证类型</p><p>枚举值：</p><ul><li>NONE： 无认证</li><li>KERBEROS： Kerberos认证</li></ul><p>开启Kerberos认证的EMR实例，此处需传入KERBEROS，创建连接时必选，编辑连接时非必选</p>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>EMR实例的HiveMetaStore节点IP绑定的弹性网卡Id列表</p><p>数量和顺序必须与ServiceVip字段中的多个IP对应，创建连接时必选，编辑连接时不接收该参数</p>
        /// </summary>
        [JsonProperty("EniIdList")]
        public string[] EniIdList{ get; set; }

        /// <summary>
        /// <p>Catalog数据目录类型</p><p>枚举值：</p><ul><li>HIVE： Hive Catalog</li></ul><p>默认值：HIVE</p><p>仅支持Hive Catalog</p>
        /// </summary>
        [JsonProperty("CatalogType")]
        public string CatalogType{ get; set; }

        /// <summary>
        /// <p>用于Kerberos认证的user.keytab文件的内容</p><p>入参限制：文件内容需使用Base64编码</p><p>AuthType为KERBEROS时必传</p>
        /// </summary>
        [JsonProperty("KeyTabContent")]
        public string KeyTabContent{ get; set; }

        /// <summary>
        /// <p>用于Kerberos认证的krb5.conf文件的内容</p><p>入参限制：文件内容需使用Base64编码</p><p>AuthType为KERBEROS时必传</p>
        /// </summary>
        [JsonProperty("KRB5ConfContent")]
        public string KRB5ConfContent{ get; set; }

        /// <summary>
        /// <p>用户的Kerberos身份凭证</p>
        /// </summary>
        [JsonProperty("KerberosUserPrincipal")]
        public string KerberosUserPrincipal{ get; set; }

        /// <summary>
        /// <p>HiveMetastore服务端配置的Kerberos Principal</p><p>hive-site.xml中hive.metastore.kerberos.principal的值</p>
        /// </summary>
        [JsonProperty("KerberosPrincipal")]
        public string KerberosPrincipal{ get; set; }

        /// <summary>
        /// <p>是否更新并重启所有关联的连接器任务</p><p>编辑连接时使用，如果不传，则根据认证类型及认证参数是否发生变化，来判断是否更新并重启所有关联的连接器任务</p>
        /// </summary>
        [JsonProperty("IsUpdate")]
        public bool? IsUpdate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceVip", this.ServiceVip);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamArraySimple(map, prefix + "EniIdList.", this.EniIdList);
            this.SetParamSimple(map, prefix + "CatalogType", this.CatalogType);
            this.SetParamSimple(map, prefix + "KeyTabContent", this.KeyTabContent);
            this.SetParamSimple(map, prefix + "KRB5ConfContent", this.KRB5ConfContent);
            this.SetParamSimple(map, prefix + "KerberosUserPrincipal", this.KerberosUserPrincipal);
            this.SetParamSimple(map, prefix + "KerberosPrincipal", this.KerberosPrincipal);
            this.SetParamSimple(map, prefix + "IsUpdate", this.IsUpdate);
        }
    }
}


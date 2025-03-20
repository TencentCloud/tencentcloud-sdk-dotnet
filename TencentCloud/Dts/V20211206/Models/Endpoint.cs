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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Endpoint : AbstractModel
    {
        
        /// <summary>
        /// 地域英文名，如：ap-guangzhou
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 节点类型，proxy表示节点类型为主机，set表示节点类型为节点。proxy类型必须填在数组第一项。tdsqlmysql类型的源/目标配置必填
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 数据库内核类型，tdsql中用于区分不同内核：percona,mariadb,mysql。注意TDSQL-C MySQL、TDSQL PostgreSQL无需填写此项值。
        /// </summary>
        [JsonProperty("DbKernel")]
        public string DbKernel{ get; set; }

        /// <summary>
        /// 数据库实例ID，格式如：cdb-powiqx8q
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例的IP地址，接入类型为非cdb时此项必填
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 实例端口，接入类型为非cdb时此项必填
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 用户名，对于访问需要用户名密码认证的实例必填
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 密码，对于访问需要用户名密码认证的实例必填
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 数据库名，数据库为cdwpg时，需要提供
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 私有网络ID，对于私有网络、专线、VPN的接入方式此项必填，格式如：vpc-92jblxto
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网ID，对于私有网络、专线、VPN的接入方式此项必填，格式如：subnet-3paxmkdz
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// CVM实例短ID，格式如：ins-olgl39y8，与云服务器控制台页面显示的实例ID相同。如果是CVM自建实例，需要传递此字段
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// 专线网关ID，对于专线接入类型此项必填，格式如：dcg-0rxtqqxb
        /// </summary>
        [JsonProperty("UniqDcgId")]
        public string UniqDcgId{ get; set; }

        /// <summary>
        /// VPN网关ID，对于vpn接入类型此项必填，格式如：vpngw-9ghexg7q
        /// </summary>
        [JsonProperty("UniqVpnGwId")]
        public string UniqVpnGwId{ get; set; }

        /// <summary>
        /// 云联网ID，对于云联网接入类型此项必填，如：ccn-afp6kltc
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 云厂商类型，当实例为RDS实例时，填写为aliyun, 其他情况均填写others，默认为others
        /// </summary>
        [JsonProperty("Supplier")]
        public string Supplier{ get; set; }

        /// <summary>
        /// 数据库版本，当实例为RDS实例时才有效，其他实例忽略，格式如：5.6或者5.7，默认为5.6
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 实例所属账号，如果为跨账号实例此项必填
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 资源所属账号 为空或self(表示本账号内资源)、other(表示跨账号资源)
        /// </summary>
        [JsonProperty("AccountMode")]
        public string AccountMode{ get; set; }

        /// <summary>
        /// 跨账号同步时的角色，只允许[a-zA-Z0-9\-\_]+，如果为跨账号实例此项必填
        /// </summary>
        [JsonProperty("AccountRole")]
        public string AccountRole{ get; set; }

        /// <summary>
        /// 外部角色id
        /// </summary>
        [JsonProperty("RoleExternalId")]
        public string RoleExternalId{ get; set; }

        /// <summary>
        /// 临时密钥Id，可通过申请扮演角色临时访问凭证获取临时密钥https://cloud.tencent.com/document/product/1312/48197，其中角色资源RoleArn的定义可参考DTS跨账号同步文档(https://cloud.tencent.com/document/product/571/68729)第4节中关于角色的定义。
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// 临时密钥Id，可通过申请扮演角色临时访问凭证获取临时密钥https://cloud.tencent.com/document/product/1312/48197，其中角色资源RoleArn的定义可参考DTS跨账号同步文档(https://cloud.tencent.com/document/product/571/68729)第4节中关于角色的定义。
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// 临时密钥Id，可通过申请扮演角色临时访问凭证获取临时密钥https://cloud.tencent.com/document/product/1312/48197，其中角色资源RoleArn的定义可参考DTS跨账号同步文档(https://cloud.tencent.com/document/product/571/68729)第4节中关于角色的定义。
        /// </summary>
        [JsonProperty("TmpToken")]
        public string TmpToken{ get; set; }

        /// <summary>
        /// 是否走加密传输、UnEncrypted表示不走加密传输，Encrypted表示走加密传输，默认UnEncrypted
        /// </summary>
        [JsonProperty("EncryptConn")]
        public string EncryptConn{ get; set; }

        /// <summary>
        /// 数据库所属网络环境，AccessType为云联网(ccn)时必填， UserIDC表示用户IDC、TencentVPC表示腾讯云VPC；
        /// </summary>
        [JsonProperty("DatabaseNetEnv")]
        public string DatabaseNetEnv{ get; set; }

        /// <summary>
        /// 数据库为跨账号云联网下的实例时、表示云联网所属主账号
        /// </summary>
        [JsonProperty("CcnOwnerUin")]
        public string CcnOwnerUin{ get; set; }

        /// <summary>
        /// 数据库为cynos、且是cynos集群内的一个子数据库实例时、该参数为该子实例的ID
        /// </summary>
        [JsonProperty("ChildInstanceId")]
        public string ChildInstanceId{ get; set; }

        /// <summary>
        /// 数据库为cynos、且是cynos集群内的一个子数据库实例时、该参数为该子实例的类型、例如：只读实例传ro、读写实例传rw
        /// </summary>
        [JsonProperty("ChildInstanceType")]
        public string ChildInstanceType{ get; set; }

        /// <summary>
        /// tdsql的分片id。如节点类型为set必填。
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "DbKernel", this.DbKernel);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "UniqDcgId", this.UniqDcgId);
            this.SetParamSimple(map, prefix + "UniqVpnGwId", this.UniqVpnGwId);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "Supplier", this.Supplier);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "AccountMode", this.AccountMode);
            this.SetParamSimple(map, prefix + "AccountRole", this.AccountRole);
            this.SetParamSimple(map, prefix + "RoleExternalId", this.RoleExternalId);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "TmpToken", this.TmpToken);
            this.SetParamSimple(map, prefix + "EncryptConn", this.EncryptConn);
            this.SetParamSimple(map, prefix + "DatabaseNetEnv", this.DatabaseNetEnv);
            this.SetParamSimple(map, prefix + "CcnOwnerUin", this.CcnOwnerUin);
            this.SetParamSimple(map, prefix + "ChildInstanceId", this.ChildInstanceId);
            this.SetParamSimple(map, prefix + "ChildInstanceType", this.ChildInstanceType);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
        }
    }
}


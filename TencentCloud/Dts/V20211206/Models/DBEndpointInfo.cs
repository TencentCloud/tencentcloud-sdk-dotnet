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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBEndpointInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例网络接入类型，如：extranet(外网)、ipv6(公网ipv6)、cvm(云服务器自建)、dcg(专线接入)、vpncloud(vpn接入的实例)、cdb(云数据库)、ccn(云联网)、intranet(自研上云)、vpc(私有网络)等，注意具体可选值依赖当前链路
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 实例数据库类型，如：mysql,redis,mongodb,postgresql,mariadb,percona 等
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// 节点类型，simple表示普通节点、cluster表示集群节点；
        /// 对于mongo业务，取值为replicaset(mongodb副本集)、standalone(mongodb单节点)、cluster(mongodb集群)；
        /// 对于redis实例，simple(单节点)、cluster-cache(直连集群)、cluster-proxy(代理集群)；
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 实例具体的连接信息，如ip、port、接入方式等
        /// </summary>
        [JsonProperty("Info")]
        public DBInfo[] Info{ get; set; }

        /// <summary>
        /// 实例服务提供商，如:"aliyun","others"
        /// </summary>
        [JsonProperty("Supplier")]
        public string Supplier{ get; set; }

        /// <summary>
        /// 此参数为数组类型，可以传多个键值对结构对象。
        /// MongoDB可定义如下的参数：
        /// 'AuthDatabase':'admin',    //认证库
        /// 'AuthFlag': "1",       //实例是否需要认证，"0": 不用认证；"1":需要认证
        /// 'AuthMechanism':"SCRAM-SHA-1",    //实例认证方式
        /// "fetchMethod":"oplog",    //fetchMethod表示迁移方式，支持oplog、change_stream
        /// "connectMode":"srv",    //外网srv连接模式
        /// "EncryptedConnProtocol":"mongo_atlas_ssl"；    //加密连接方式
        /// 其中fetchMethod表示迁移方式，还可支持change_stream；EncryptedConnProtocol值为mongo_atlas_ssl表示使用atlas ssl连接方式。
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

        /// <summary>
        /// 数据库所属网络环境，AccessType为云联网(ccn)时必填， UserIDC表示用户IDC、TencentVPC表示腾讯云VPC；
        /// </summary>
        [JsonProperty("DatabaseNetEnv")]
        public string DatabaseNetEnv{ get; set; }

        /// <summary>
        /// tdsql连接方式：proxy-通过tdsql proxy主机访问各个set节点，注意只有在自研上云的网络环境下才能通过这种方式连接，Info中只需要提供proxy主机信息。set-直连set节点，如选择直连set方式，Info中需要正确填写proxy主机信息及所有set节点信息。源端是tdsqlmysql类型必填。
        /// </summary>
        [JsonProperty("ConnectType")]
        public string ConnectType{ get; set; }

        /// <summary>
        /// 云联网网关所属账号，如果云联网网关为其他账号资源需要填写
        /// </summary>
        [JsonProperty("CcnOwnerUin")]
        public string CcnOwnerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamArrayObj(map, prefix + "Info.", this.Info);
            this.SetParamSimple(map, prefix + "Supplier", this.Supplier);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
            this.SetParamSimple(map, prefix + "DatabaseNetEnv", this.DatabaseNetEnv);
            this.SetParamSimple(map, prefix + "ConnectType", this.ConnectType);
            this.SetParamSimple(map, prefix + "CcnOwnerUin", this.CcnOwnerUin);
        }
    }
}


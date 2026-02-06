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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDataSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据源的配置信息，以JSON KV存储，根据每个数据源类型不同，而KV存储信息不同
        /// 
        /// > deployType: 
        /// CONNSTR_PUBLICDB(公网实例) 
        /// CONNSTR_CVMDB(自建实例)
        /// INSTANCE(云实例)
        /// 
        /// ```
        /// mysql: 自建实例
        /// {
        ///     "deployType": "CONNSTR_CVMDB",
        ///     "url": "jdbc:mysql://1.1.1.1:1111/example#test#123456",
        ///     "username": "root",
        ///     "password": "example#test#123456",
        ///     "region": "ap-shanghai",
        ///     "vpcId": "vpc-kprq42yo",
        ///     "type": "MYSQL"
        /// }
        /// mysql: 云实例
        /// {
        ///     "instanceid": "cdb-12uxdo5e",
        ///     "db": "db",
        ///     "region": "ap-shanghai",
        ///     "username": "msyql",
        ///     "password": "example#test#123456",
        ///     "deployType": "INSTANCE",
        ///     "type": "TENCENT_MYSQL"
        /// }
        /// sql_server: 
        /// {
        ///     "deployType": "CONNSTR_PUBLICDB",
        ///     "url": "jdbc:sqlserver://1.1.1.1:223;example#test#123456",
        ///     "username": "user_1",
        ///     "password": "example#test#123456",
        ///     "type": "SQLSERVER"
        /// }
        /// redis:
        ///     redisType:
        ///     -NO_ACCOUT(免账号)
        ///     -SELF_ACCOUNT(自定义账号)
        /// {
        ///     "deployType": "CONNSTR_PUBLICDB",
        ///     "username":""
        ///     "password": "example#test#123456",
        ///     "ip": "1.1.1.1",
        ///     "port": "6379",
        ///     "redisType": "NO_ACCOUT",
        ///     "type": "REDIS"
        /// }
        /// oracle: 
        /// {
        ///     "deployType": "CONNSTR_CVMDB",
        ///     "url": "jdbc:oracle:thin:@1.1.1.1:1521:example#test#123456",
        ///     "username": "oracle",
        ///     "password": "example#test#123456",
        ///     "region": "ap-shanghai",
        ///     "vpcId": "vpc-kprq42yo",
        ///     "type": "ORACLE"
        /// }
        /// mongodb:
        ///     advanceParams(自定义参数，会拼接至url后)
        /// {
        ///     "advanceParams": [
        ///         {
        ///             "key": "authSource",
        ///             "value": "auth"
        ///         }
        ///     ],
        ///     "db": "admin",
        ///     "deployType": "CONNSTR_PUBLICDB",
        ///     "username": "user",
        ///     "password": "example#test#123456",
        ///     "type": "MONGODB",
        ///     "host": "1.1.1.1:9200"
        /// }
        /// postgresql:
        /// {
        ///     "deployType": "CONNSTR_PUBLICDB",
        ///     "url": "jdbc:postgresql://1.1.1.1:1921/example#test#123456",
        ///     "username": "user",
        ///     "password": "example#test#123456",
        ///     "type": "POSTGRE"
        /// }
        /// kafka:
        ///     authType:
        ///         - sasl
        ///         - jaas
        ///         - sasl_plaintext
        ///         - sasl_ssl
        ///         - GSSAPI
        ///     ssl:
        ///         -PLAIN
        ///         -GSSAPI
        /// {
        ///     "deployType": "CONNSTR_PUBLICDB",
        ///     "host": "1.1.1.1:9092",
        ///     "ssl": "GSSAPI",
        ///     "authType": "sasl",
        ///     "type": "KAFKA",
        ///     "principal": "aaaa",
        ///     "serviceName": "kafka"
        /// }
        /// 
        /// cos:
        /// {
        ///     "region": "ap-shanghai",
        ///     "deployType": "INSTANCE",
        ///     "secretId": "aaaaa",
        ///     "secretKey": "example#test#123456",
        ///     "bucket": "aaa",
        ///     "type": "COS"
        /// }
        /// 
        /// ```
        /// </summary>
        [JsonProperty("ProdConProperties")]
        public string ProdConProperties{ get; set; }

        /// <summary>
        /// 若项目为标准模式，则此字段必填
        /// </summary>
        [JsonProperty("DevConProperties")]
        public string DevConProperties{ get; set; }

        /// <summary>
        /// 生产环境数据源文件上传
        /// </summary>
        [JsonProperty("ProdFileUpload")]
        public DataSourceFileUpload ProdFileUpload{ get; set; }

        /// <summary>
        /// 开发环境数据源文件上传
        /// </summary>
        [JsonProperty("DevFileUpload")]
        public DataSourceFileUpload DevFileUpload{ get; set; }

        /// <summary>
        /// 数据源展示名，为了可视化查看
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 数据源描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProdConProperties", this.ProdConProperties);
            this.SetParamSimple(map, prefix + "DevConProperties", this.DevConProperties);
            this.SetParamObj(map, prefix + "ProdFileUpload.", this.ProdFileUpload);
            this.SetParamObj(map, prefix + "DevFileUpload.", this.DevFileUpload);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}


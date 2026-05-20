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

    public class CreateDataSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据源项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>数据源名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数据源类型:枚举值- MYSQL- TENCENT_MYSQL- POSTGRE- ORACLE- SQLSERVER- FTP- HIVE- HUDI- HDFS- ICEBERG- KAFKA- DTS_KAFKA- HBASE- SPARK- TBASE- DB2- DM- GAUSSDB- GBASE- IMPALA- ES- TENCENT_ES- GREENPLUM- SAP_HANA- SFTP- OCEANBASE- CLICKHOUSE- KUDU- VERTICA- REDIS- COS- DLC- DORIS- CKAFKA- S3_DATAINSIGHT- TDSQL- TDSQL_MYSQL- MONGODB- TENCENT_MONGODB- REST_API- TiDB- StarRocks- Trino- Kyuubi- TCHOUSE_X- TCHOUSE_P- TCHOUSE_C- TCHOUSE_D- INFLUXDB- BIG_QUERY- SSH- BLOB- TDSQL_POSTGRE- GDB- TDENGINE- TDSQLC- FileSystem- TCLake- TDSQL_BOUNDLESS</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>数据源的配置信息，以JSON KV存储，根据每个数据源类型不同，而KV存储信息不同</p><blockquote><p>deployType:<br>CONNSTR_PUBLICDB(公网实例)<br>CONNSTR_CVMDB(自建实例)<br>INSTANCE(云实例)</p></blockquote><p><pre><code>mysql: 自建实例{    &quot;deployType&quot;: &quot;CONNSTR_CVMDB&quot;,    &quot;url&quot;: &quot;jdbc:mysql://1.1.1.1:1111/example#test#123456&quot;,    &quot;username&quot;: &quot;root&quot;,    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;region&quot;: &quot;ap-shanghai&quot;,    &quot;vpcId&quot;: &quot;vpc-kprq42yo&quot;,    &quot;type&quot;: &quot;MYSQL&quot;}mysql: 云实例{    &quot;instanceid&quot;: &quot;cdb-12uxdo5e&quot;,    &quot;db&quot;: &quot;db&quot;,    &quot;region&quot;: &quot;ap-shanghai&quot;,    &quot;username&quot;: &quot;msyql&quot;,    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;deployType&quot;: &quot;INSTANCE&quot;,    &quot;type&quot;: &quot;TENCENT_MYSQL&quot;}sql_server: {    &quot;deployType&quot;: &quot;CONNSTR_PUBLICDB&quot;,    &quot;url&quot;: &quot;jdbc:sqlserver://1.1.1.1:223;example#test#123456&quot;,    &quot;username&quot;: &quot;user_1&quot;,    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;type&quot;: &quot;SQLSERVER&quot;}redis:    redisType:    -NO_ACCOUT(免账号)    -SELF_ACCOUNT(自定义账号){    &quot;deployType&quot;: &quot;CONNSTR_PUBLICDB&quot;,    &quot;username&quot;:&quot;&quot;    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;ip&quot;: &quot;1.1.1.1&quot;,    &quot;port&quot;: &quot;6379&quot;,    &quot;redisType&quot;: &quot;NO_ACCOUT&quot;,    &quot;type&quot;: &quot;REDIS&quot;}oracle: {    &quot;deployType&quot;: &quot;CONNSTR_CVMDB&quot;,    &quot;url&quot;: &quot;jdbc:oracle:thin:@1.1.1.1:1521:example#test#123456&quot;,    &quot;username&quot;: &quot;oracle&quot;,    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;region&quot;: &quot;ap-shanghai&quot;,    &quot;vpcId&quot;: &quot;vpc-kprq42yo&quot;,    &quot;type&quot;: &quot;ORACLE&quot;}mongodb:    advanceParams(自定义参数，会拼接至url后){    &quot;advanceParams&quot;: [        {            &quot;key&quot;: &quot;authSource&quot;,            &quot;value&quot;: &quot;auth&quot;        }    ],    &quot;db&quot;: &quot;admin&quot;,    &quot;deployType&quot;: &quot;CONNSTR_PUBLICDB&quot;,    &quot;username&quot;: &quot;user&quot;,    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;type&quot;: &quot;MONGODB&quot;,    &quot;host&quot;: &quot;1.1.1.1:9200&quot;}postgresql:{    &quot;deployType&quot;: &quot;CONNSTR_PUBLICDB&quot;,    &quot;url&quot;: &quot;jdbc:postgresql://1.1.1.1:1921/example#test#123456&quot;,    &quot;username&quot;: &quot;user&quot;,    &quot;password&quot;: &quot;example#test#123456&quot;,    &quot;type&quot;: &quot;POSTGRE&quot;}kafka:    authType:        - sasl        - jaas        - sasl_plaintext        - sasl_ssl        - GSSAPI    ssl:        -PLAIN        -GSSAPI{    &quot;deployType&quot;: &quot;CONNSTR_PUBLICDB&quot;,    &quot;host&quot;: &quot;1.1.1.1:9092&quot;,    &quot;ssl&quot;: &quot;GSSAPI&quot;,    &quot;authType&quot;: &quot;sasl&quot;,    &quot;type&quot;: &quot;KAFKA&quot;,    &quot;principal&quot;: &quot;aaaa&quot;,    &quot;serviceName&quot;: &quot;kafka&quot;}cos:{    &quot;region&quot;: &quot;ap-shanghai&quot;,    &quot;deployType&quot;: &quot;INSTANCE&quot;,    &quot;secretId&quot;: &quot;aaaaa&quot;,    &quot;secretKey&quot;: &quot;example#test#123456&quot;,    &quot;bucket&quot;: &quot;aaa&quot;,    &quot;type&quot;: &quot;COS&quot;}</code></pre></p>
        /// </summary>
        [JsonProperty("ProdConProperties")]
        public string ProdConProperties{ get; set; }

        /// <summary>
        /// <p>开发环境数据源配置信息，若项目为标准模式，则此字段必填</p>
        /// </summary>
        [JsonProperty("DevConProperties")]
        public string DevConProperties{ get; set; }

        /// <summary>
        /// <p>生产环境数据源文件上传</p>
        /// </summary>
        [JsonProperty("ProdFileUpload")]
        public DataSourceFileUpload ProdFileUpload{ get; set; }

        /// <summary>
        /// <p>开发环境数据源文件上传</p>
        /// </summary>
        [JsonProperty("DevFileUpload")]
        public DataSourceFileUpload DevFileUpload{ get; set; }

        /// <summary>
        /// <p>数据源展示名，为了可视化查看</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>数据源描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProdConProperties", this.ProdConProperties);
            this.SetParamSimple(map, prefix + "DevConProperties", this.DevConProperties);
            this.SetParamObj(map, prefix + "ProdFileUpload.", this.ProdFileUpload);
            this.SetParamObj(map, prefix + "DevFileUpload.", this.DevFileUpload);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}


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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HiveInfo : AbstractModel
    {
        
        /// <summary>
        /// hive metastore的地址
        /// </summary>
        [JsonProperty("MetaStoreUrl")]
        public string MetaStoreUrl{ get; set; }

        /// <summary>
        /// hive数据源类型，代表数据储存的位置，COS或者HDFS
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据源所在的私有网络信息
        /// </summary>
        [JsonProperty("Location")]
        public DatasourceConnectionLocation Location{ get; set; }

        /// <summary>
        /// 如果类型为HDFS，需要传一个用户名
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 如果类型为HDFS，需要选择是否高可用
        /// </summary>
        [JsonProperty("HighAvailability")]
        public bool? HighAvailability{ get; set; }

        /// <summary>
        /// 如果类型为COS，需要填写COS桶连接
        /// </summary>
        [JsonProperty("BucketUrl")]
        public string BucketUrl{ get; set; }

        /// <summary>
        /// json字符串。如果类型为HDFS，需要填写该字段
        /// </summary>
        [JsonProperty("HdfsProperties")]
        public string HdfsProperties{ get; set; }

        /// <summary>
        /// Hive的元数据库信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mysql")]
        public MysqlInfo Mysql{ get; set; }

        /// <summary>
        /// emr集群Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// emr集群名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// EMR集群中hive组件的版本号
        /// </summary>
        [JsonProperty("HiveVersion")]
        public string HiveVersion{ get; set; }

        /// <summary>
        /// Kerberos详细信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KerberosInfo")]
        public KerberosInfo KerberosInfo{ get; set; }

        /// <summary>
        /// 是否开启Kerberos
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KerberosEnable")]
        public bool? KerberosEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetaStoreUrl", this.MetaStoreUrl);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "HighAvailability", this.HighAvailability);
            this.SetParamSimple(map, prefix + "BucketUrl", this.BucketUrl);
            this.SetParamSimple(map, prefix + "HdfsProperties", this.HdfsProperties);
            this.SetParamObj(map, prefix + "Mysql.", this.Mysql);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "HiveVersion", this.HiveVersion);
            this.SetParamObj(map, prefix + "KerberosInfo.", this.KerberosInfo);
            this.SetParamSimple(map, prefix + "KerberosEnable", this.KerberosEnable);
        }
    }
}


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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatasourceConnectionInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据源数字Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 数据源字符串Id
        /// </summary>
        [JsonProperty("DatasourceConnectionId")]
        public string DatasourceConnectionId{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 数据源描述
        /// </summary>
        [JsonProperty("DatasourceConnectionDesc")]
        public string DatasourceConnectionDesc{ get; set; }

        /// <summary>
        /// 数据源类型，支持DataLakeCatalog、IcebergCatalog、Result、Mysql、HiveCos、HiveHdfs
        /// </summary>
        [JsonProperty("DatasourceConnectionType")]
        public string DatasourceConnectionType{ get; set; }

        /// <summary>
        /// 数据源属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionConfig")]
        public DatasourceConnectionConfig DatasourceConnectionConfig{ get; set; }

        /// <summary>
        /// 数据源状态：0（初始化）、1（成功）、-1（已删除）、-2（失败）、-3（删除中）
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 数据源创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 数据源最近一次更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 数据源同步失败原因
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 数据源绑定的计算引擎信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngines")]
        public DataEngineInfo[] DataEngines{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// 网络配置列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkConnectionSet")]
        public NetworkConnection[] NetworkConnectionSet{ get; set; }

        /// <summary>
        /// 连通性状态：0（未测试，默认）、1（正常）、2（失败）
        /// </summary>
        [JsonProperty("ConnectivityState")]
        public ulong? ConnectivityState{ get; set; }

        /// <summary>
        /// 连通性测试提示信息
        /// </summary>
        [JsonProperty("ConnectivityTips")]
        public string ConnectivityTips{ get; set; }

        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("CustomConfig")]
        public CustomConfig[] CustomConfig{ get; set; }

        /// <summary>
        /// 是否允许回退
        /// </summary>
        [JsonProperty("AllowRollback")]
        public bool? AllowRollback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DatasourceConnectionId", this.DatasourceConnectionId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionDesc", this.DatasourceConnectionDesc);
            this.SetParamSimple(map, prefix + "DatasourceConnectionType", this.DatasourceConnectionType);
            this.SetParamObj(map, prefix + "DatasourceConnectionConfig.", this.DatasourceConnectionConfig);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "DataEngines.", this.DataEngines);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamArrayObj(map, prefix + "NetworkConnectionSet.", this.NetworkConnectionSet);
            this.SetParamSimple(map, prefix + "ConnectivityState", this.ConnectivityState);
            this.SetParamSimple(map, prefix + "ConnectivityTips", this.ConnectivityTips);
            this.SetParamArrayObj(map, prefix + "CustomConfig.", this.CustomConfig);
            this.SetParamSimple(map, prefix + "AllowRollback", this.AllowRollback);
        }
    }
}


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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDspmExportTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 风险等级(0-安全,1-低风险,2-中风险,3-高风险,-1-全部)
        /// </summary>
        [JsonProperty("DangerLevel")]
        public long? DangerLevel{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("DbPort")]
        public long? DbPort{ get; set; }

        /// <summary>
        /// 数据库 IP
        /// </summary>
        [JsonProperty("DbIp")]
        public string DbIp{ get; set; }

        /// <summary>
        /// 资产 ID
        /// </summary>
        [JsonProperty("AssetsId")]
        public long? AssetsId{ get; set; }

        /// <summary>
        /// 会话 ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 客户端 IP
        /// </summary>
        [JsonProperty("ClientSideIp")]
        public string ClientSideIp{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 命中规则
        /// </summary>
        [JsonProperty("HitRule")]
        public long? HitRule{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 模糊查询
        /// </summary>
        [JsonProperty("FuzzySearch")]
        public string FuzzySearch{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 客户端
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// 流量来源，取值 Agent/Proxy/空；传Agent会返回Agent的日志，传Proxy会返回Proxy日志，两都都传或不传则返回所有
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// 表名，长度限制64，多个表名查询的话可以用空格连接	
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 字段名，长度限制64，多个字段名查询的话可以用空格连接
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// SQL 主要类型，DDL, DML, DCL, TCL	
        /// </summary>
        [JsonProperty("SqlMainTypes")]
        public string[] SqlMainTypes{ get; set; }

        /// <summary>
        /// 操作类型	
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// 影响行数最小值	
        /// </summary>
        [JsonProperty("RowNumMin")]
        public long? RowNumMin{ get; set; }

        /// <summary>
        /// 影响行数最大值	
        /// </summary>
        [JsonProperty("RowNumMax")]
        public long? RowNumMax{ get; set; }

        /// <summary>
        /// 数据库类型	
        /// </summary>
        [JsonProperty("DbTypes")]
        public string[] DbTypes{ get; set; }

        /// <summary>
        /// 返回码	
        /// </summary>
        [JsonProperty("RetNo")]
        public long? RetNo{ get; set; }

        /// <summary>
        /// 客户端工具	
        /// </summary>
        [JsonProperty("ClientDriverName")]
        public string ClientDriverName{ get; set; }

        /// <summary>
        /// 客户端端口	
        /// </summary>
        [JsonProperty("ClientPort")]
        public long? ClientPort{ get; set; }

        /// <summary>
        /// 审计日志 ID
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// 风险等级数组(0-安全,1-低风险,2-中风险,3-高风险), 如果要全部，则需要将所有的值都传入。如果为空，则会参考：DangerLevel 入参
        /// </summary>
        [JsonProperty("DangerLevels")]
        public long?[] DangerLevels{ get; set; }

        /// <summary>
        /// 字段分类
        /// </summary>
        [JsonProperty("SensitiveCategoryRule")]
        public string SensitiveCategoryRule{ get; set; }

        /// <summary>
        /// 字段分级
        /// </summary>
        [JsonProperty("SensitiveLevelRisk")]
        public string SensitiveLevelRisk{ get; set; }

        /// <summary>
        /// 事务Id
        /// </summary>
        [JsonProperty("TrxId")]
        public long? TrxId{ get; set; }

        /// <summary>
        /// clientMac
        /// </summary>
        [JsonProperty("ClientMac")]
        public string ClientMac{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "DangerLevel", this.DangerLevel);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbIp", this.DbIp);
            this.SetParamSimple(map, prefix + "AssetsId", this.AssetsId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ClientSideIp", this.ClientSideIp);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "HitRule", this.HitRule);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FuzzySearch", this.FuzzySearch);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamArraySimple(map, prefix + "SqlMainTypes.", this.SqlMainTypes);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "RowNumMin", this.RowNumMin);
            this.SetParamSimple(map, prefix + "RowNumMax", this.RowNumMax);
            this.SetParamArraySimple(map, prefix + "DbTypes.", this.DbTypes);
            this.SetParamSimple(map, prefix + "RetNo", this.RetNo);
            this.SetParamSimple(map, prefix + "ClientDriverName", this.ClientDriverName);
            this.SetParamSimple(map, prefix + "ClientPort", this.ClientPort);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamArraySimple(map, prefix + "DangerLevels.", this.DangerLevels);
            this.SetParamSimple(map, prefix + "SensitiveCategoryRule", this.SensitiveCategoryRule);
            this.SetParamSimple(map, prefix + "SensitiveLevelRisk", this.SensitiveLevelRisk);
            this.SetParamSimple(map, prefix + "TrxId", this.TrxId);
            this.SetParamSimple(map, prefix + "ClientMac", this.ClientMac);
        }
    }
}


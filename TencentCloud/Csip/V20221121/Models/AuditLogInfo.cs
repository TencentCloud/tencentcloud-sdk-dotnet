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

    public class AuditLogInfo : AbstractModel
    {
        
        /// <summary>
        /// ai分数
        /// </summary>
        [JsonProperty("AiScore")]
        public float? AiScore{ get; set; }

        /// <summary>
        /// 应用用户
        /// </summary>
        [JsonProperty("AppUser")]
        public string AppUser{ get; set; }

        /// <summary>
        /// 备份数据包
        /// </summary>
        [JsonProperty("BackPacket")]
        public string BackPacket{ get; set; }

        /// <summary>
        /// 客户端 IP
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 客户端 Mac
        /// </summary>
        [JsonProperty("ClientMac")]
        public string ClientMac{ get; set; }

        /// <summary>
        /// 终端名称，取值Proxy时为casb代理流量，其它为Agent流量
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// 客户端用户
        /// </summary>
        [JsonProperty("ClientUser")]
        public string ClientUser{ get; set; }

        /// <summary>
        /// 客户端端口
        /// </summary>
        [JsonProperty("ClientPort")]
        public ulong? ClientPort{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("DangerLevel")]
        public ulong? DangerLevel{ get; set; }

        /// <summary>
        /// 数据库 IP
        /// </summary>
        [JsonProperty("DbIp")]
        public string DbIp{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("DbPort")]
        public ulong? DbPort{ get; set; }

        /// <summary>
        /// 数据库用户
        /// </summary>
        [JsonProperty("DbUser")]
        public string DbUser{ get; set; }

        /// <summary>
        /// 影响行数
        /// </summary>
        [JsonProperty("EffectRow")]
        public ulong? EffectRow{ get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("ExecTime")]
        public ulong? ExecTime{ get; set; }

        /// <summary>
        /// 命中规则
        /// </summary>
        [JsonProperty("HitRule")]
        public string HitRule{ get; set; }

        /// <summary>
        /// 日志 ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 数据资产名称
        /// </summary>
        [JsonProperty("InstanceId")]
        public ulong? InstanceId{ get; set; }

        /// <summary>
        /// 审计单元名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 操作语句(sql 语句)
        /// </summary>
        [JsonProperty("OpSql")]
        public string OpSql{ get; set; }

        /// <summary>
        /// 操作时间(时间)
        /// </summary>
        [JsonProperty("OpTime")]
        public ulong? OpTime{ get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty("RetNo")]
        public ulong? RetNo{ get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 数据资产名称
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 规则集合
        /// </summary>
        [JsonProperty("HitRules")]
        public HitRules[] HitRules{ get; set; }

        /// <summary>
        /// 流量来源
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 单条审计日志id
        /// </summary>
        [JsonProperty("ReqId")]
        public string ReqId{ get; set; }

        /// <summary>
        /// SQL 主要类型，DML/DDL/DCL/TCL
        /// </summary>
        [JsonProperty("SqlMainType")]
        public string SqlMainType{ get; set; }

        /// <summary>
        /// 表名集合
        /// </summary>
        [JsonProperty("TableNames")]
        public string[] TableNames{ get; set; }

        /// <summary>
        /// 字段名集合
        /// </summary>
        [JsonProperty("FieldNames")]
        public string[] FieldNames{ get; set; }

        /// <summary>
        /// 字段名
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 客户端工具
        /// </summary>
        [JsonProperty("ClientDriverName")]
        public string ClientDriverName{ get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }

        /// <summary>
        /// 字段信息（包含敏感信息）
        /// </summary>
        [JsonProperty("FieldDetails")]
        public TableField[] FieldDetails{ get; set; }

        /// <summary>
        /// 资产所属账号app id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 账号昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 资产所属账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AiScore", this.AiScore);
            this.SetParamSimple(map, prefix + "AppUser", this.AppUser);
            this.SetParamSimple(map, prefix + "BackPacket", this.BackPacket);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ClientMac", this.ClientMac);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamSimple(map, prefix + "ClientUser", this.ClientUser);
            this.SetParamSimple(map, prefix + "ClientPort", this.ClientPort);
            this.SetParamSimple(map, prefix + "DangerLevel", this.DangerLevel);
            this.SetParamSimple(map, prefix + "DbIp", this.DbIp);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "EffectRow", this.EffectRow);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "HitRule", this.HitRule);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "OpSql", this.OpSql);
            this.SetParamSimple(map, prefix + "OpTime", this.OpTime);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "RetNo", this.RetNo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamArrayObj(map, prefix + "HitRules.", this.HitRules);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ReqId", this.ReqId);
            this.SetParamSimple(map, prefix + "SqlMainType", this.SqlMainType);
            this.SetParamArraySimple(map, prefix + "TableNames.", this.TableNames);
            this.SetParamArraySimple(map, prefix + "FieldNames.", this.FieldNames);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "ClientDriverName", this.ClientDriverName);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamArrayObj(map, prefix + "FieldDetails.", this.FieldDetails);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}


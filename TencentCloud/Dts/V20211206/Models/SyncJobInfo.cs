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

    public class SyncJobInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>同步任务id，如：sync-btso140</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>同步任务名</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>付款方式，PostPay(按量付费)、PrePay(包年包月)</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>运行模式，Immediate(表示立即运行，默认为此项值)、Timed(表示定时运行)</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>期待运行时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("ExpectRunTime")]
        public string ExpectRunTime{ get; set; }

        /// <summary>
        /// <p>支持的所有操作</p>
        /// </summary>
        [JsonProperty("AllActions")]
        public string[] AllActions{ get; set; }

        /// <summary>
        /// <p>当前状态能进行的操作</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Actions")]
        public string[] Actions{ get; set; }

        /// <summary>
        /// <p>同步选项</p>
        /// </summary>
        [JsonProperty("Options")]
        public Options Options{ get; set; }

        /// <summary>
        /// <p>同步库表对象</p>
        /// </summary>
        [JsonProperty("Objects")]
        public Objects Objects{ get; set; }

        /// <summary>
        /// <p>任务规格</p>
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// <p>过期时间，格式为 yyyy-mm-dd hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>源端地域，如：ap-guangzhou等</p>
        /// </summary>
        [JsonProperty("SrcRegion")]
        public string SrcRegion{ get; set; }

        /// <summary>
        /// <p>源端数据库类型，mysql,tdsqlmysql,mariadb,cynosdbmysql(表示tdsql-c实例),tdstore,percona,postgresql,mongodb等。</p>
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// <p>源端接入类型，cdb(云数据库)、cvm(云服务器自建)、vpc(私有网络)、extranet(外网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、intranet(自研上云)</p>
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// <p>源端信息，单节点数据库使用</p>
        /// </summary>
        [JsonProperty("SrcInfo")]
        public Endpoint SrcInfo{ get; set; }

        /// <summary>
        /// <p>枚举值：cluster、single。源库为单节点数据库使用single，多节点使用cluster</p>
        /// </summary>
        [JsonProperty("SrcNodeType")]
        public string SrcNodeType{ get; set; }

        /// <summary>
        /// <p>源端信息，若SrcNodeType=cluster，则源端信息在这个字段里，mongodb链路使用此参数透传。</p>
        /// </summary>
        [JsonProperty("SrcInfos")]
        public SyncDBEndpointInfos SrcInfos{ get; set; }

        /// <summary>
        /// <p>目标端地域，如：ap-guangzhou等</p>
        /// </summary>
        [JsonProperty("DstRegion")]
        public string DstRegion{ get; set; }

        /// <summary>
        /// <p>目标端数据库类型，mysql,tdsqlmysql,mariadb,cynosdbmysql(表示tdsql-c实例),tdstore,percona,postgresql,mongodb等。</p>
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// <p>目标端接入类型，cdb(云数据库)、cvm(云主机自建)、vpc(私有网络)、extranet(外网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、intranet(自研上云)</p>
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// <p>目标端信息，单节点数据库使用</p>
        /// </summary>
        [JsonProperty("DstInfo")]
        public Endpoint DstInfo{ get; set; }

        /// <summary>
        /// <p>枚举值：cluster、single。目标库为单节点数据库使用single，多节点使用cluster</p>
        /// </summary>
        [JsonProperty("DstNodeType")]
        public string DstNodeType{ get; set; }

        /// <summary>
        /// <p>目标端信息，若SrcNodeType=cluster，则源端信息在这个字段里，mongodb链路使用此参数透传。</p>
        /// </summary>
        [JsonProperty("DstInfos")]
        public SyncDBEndpointInfos DstInfos{ get; set; }

        /// <summary>
        /// <p>创建时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>开始时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>任务状态，UnInitialized(未初始化)、Initialized(已初始化)、Checking(校验中)、CheckPass(校验通过)、CheckNotPass(校验不通过)、ReadyRunning(准备运行)、Running(运行中)、Pausing(暂停中)、Paused(已暂停)、Stopping(停止中)、Stopped(已结束)、ResumableErr(任务错误)、Resuming(恢复中)、Failed(失败)、Released(已释放)、Resetting(重置中)、Unknown(未知)</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>结束时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>标签相关信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagItem[] Tags{ get; set; }

        /// <summary>
        /// <p>同步任务运行步骤信息</p>
        /// </summary>
        [JsonProperty("Detail")]
        public SyncDetailInfo Detail{ get; set; }

        /// <summary>
        /// <p>用于计费的状态，可能取值有：Normal(正常状态)、Resizing(变配中)、Renewing(续费中)、Isolating(隔离中)、Isolated(已隔离)、Offlining(下线中)、Offlined(已下线)、NotBilled(未计费)、Recovering(解隔离)、PostPay2Prepaying(按量计费转包年包月中)、PrePay2Postpaying(包年包月转按量计费中)</p>
        /// </summary>
        [JsonProperty("TradeStatus")]
        public string TradeStatus{ get; set; }

        /// <summary>
        /// <p>同步链路规格，如micro,small,medium,large</p>
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// <p>自动续费标识，当PayMode值为PrePay则此项配置有意义，取值为：1（表示自动续费）、0（不自动续费）</p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>下线时间，格式为 yyyy-mm-dd hh:mm:ss</p>
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// <p>动态修改对象，修改任务的状态等</p>
        /// </summary>
        [JsonProperty("OptObjStatus")]
        public string OptObjStatus{ get; set; }

        /// <summary>
        /// <p>自动重试时间段设置</p>
        /// </summary>
        [JsonProperty("AutoRetryTimeRangeMinutes")]
        public long? AutoRetryTimeRangeMinutes{ get; set; }

        /// <summary>
        /// <p>全量导出可重入标识：enum::&quot;yes&quot;/&quot;no&quot;。yes表示当前任务可重入、no表示当前任务处于全量导出且不可重入阶段；如果在该值为no时重启任务导出流程不支持断点续传</p>
        /// </summary>
        [JsonProperty("DumperResumeCtrl")]
        public string DumperResumeCtrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ExpectRunTime", this.ExpectRunTime);
            this.SetParamArraySimple(map, prefix + "AllActions.", this.AllActions);
            this.SetParamArraySimple(map, prefix + "Actions.", this.Actions);
            this.SetParamObj(map, prefix + "Options.", this.Options);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "SrcRegion", this.SrcRegion);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "SrcNodeType", this.SrcNodeType);
            this.SetParamObj(map, prefix + "SrcInfos.", this.SrcInfos);
            this.SetParamSimple(map, prefix + "DstRegion", this.DstRegion);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "DstNodeType", this.DstNodeType);
            this.SetParamObj(map, prefix + "DstInfos.", this.DstInfos);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
            this.SetParamSimple(map, prefix + "TradeStatus", this.TradeStatus);
            this.SetParamSimple(map, prefix + "InstanceClass", this.InstanceClass);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "OptObjStatus", this.OptObjStatus);
            this.SetParamSimple(map, prefix + "AutoRetryTimeRangeMinutes", this.AutoRetryTimeRangeMinutes);
            this.SetParamSimple(map, prefix + "DumperResumeCtrl", this.DumperResumeCtrl);
        }
    }
}


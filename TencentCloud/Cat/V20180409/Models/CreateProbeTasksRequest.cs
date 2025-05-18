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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProbeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量任务名-地址
        /// </summary>
        [JsonProperty("BatchTasks")]
        public ProbeTaskBasicConfiguration[] BatchTasks{ get; set; }

        /// <summary>
        /// 任务类型，如1、2、3、4、5、6、7；1-页面性能、2-文件上传、3-文件下载、4-端口性能、5-网络质量、6-音视频体验、7-域名whois
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 拨测节点，如10001，具体拨测地域运营商对应的拨测点编号可联系云拨测确认。
        /// </summary>
        [JsonProperty("Nodes")]
        public string[] Nodes{ get; set; }

        /// <summary>
        /// 拨测间隔，单位为分钟
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 拨测参数，详细可参考云拨测官方文档,链接:https://cloud.tencent.com/document/product/248/87308#createprobetasks。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 任务分类
        /// <li>1 = PC</li>
        /// <li> 2 = Mobile </li>
        /// </summary>
        [JsonProperty("TaskCategory")]
        public long? TaskCategory{ get; set; }

        /// <summary>
        /// 定时任务cron表达式
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// 资源标签值
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 测试类型，包含定时测试与即时测试。0-定时拨测，其它表示即时拨测。
        /// </summary>
        [JsonProperty("ProbeType")]
        public ulong? ProbeType{ get; set; }

        /// <summary>
        /// 插件类型，如CDN，详情参考云拨测官方文档。
        /// </summary>
        [JsonProperty("PluginSource")]
        public string PluginSource{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("ClientNum")]
        public string ClientNum{ get; set; }

        /// <summary>
        /// 拨测点IP类型：0-不限制IP类型，1-IPv4，2-IPv6
        /// </summary>
        [JsonProperty("NodeIpType")]
        public long? NodeIpType{ get; set; }

        /// <summary>
        /// 供应商子账户同步标志
        /// </summary>
        [JsonProperty("SubSyncFlag")]
        public long? SubSyncFlag{ get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        [JsonProperty("RtxName")]
        public string RtxName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "BatchTasks.", this.BatchTasks);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "TaskCategory", this.TaskCategory);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProbeType", this.ProbeType);
            this.SetParamSimple(map, prefix + "PluginSource", this.PluginSource);
            this.SetParamSimple(map, prefix + "ClientNum", this.ClientNum);
            this.SetParamSimple(map, prefix + "NodeIpType", this.NodeIpType);
            this.SetParamSimple(map, prefix + "SubSyncFlag", this.SubSyncFlag);
            this.SetParamSimple(map, prefix + "RtxName", this.RtxName);
        }
    }
}


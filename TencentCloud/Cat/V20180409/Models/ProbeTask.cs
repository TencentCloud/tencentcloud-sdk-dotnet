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

    public class ProbeTask : AbstractModel
    {
        
        /// <summary>
        /// 任务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务 ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 拨测类型
        /// <li>1 = 页面浏览</li>
        /// <li> 2 =文件上传 </li>
        /// <li> 3 = 文件下载</li>
        /// <li> 4 = 端口性能 </li>
        /// <li> 5 = 网络质量 </li>
        /// <li> 6 =流媒体 </li>
        /// 
        /// 即时拨测只支持页面浏览，网络质量，文件下载
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 拨测节点列表
        /// </summary>
        [JsonProperty("Nodes")]
        public string[] Nodes{ get; set; }

        /// <summary>
        /// 拨测任务所选的拨测点IP类型，0-不限，1-IPv4，2-IPv6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeIpType")]
        public long? NodeIpType{ get; set; }

        /// <summary>
        /// 拨测间隔
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 拨测参数
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 任务状态
        /// <li>1 = 创建中</li>
        /// <li> 2 = 运行中 </li>
        /// <li> 3 = 运行异常 </li>
        /// <li> 4 = 暂停中 </li>
        /// <li> 5 = 暂停异常 </li>
        /// <li> 6 = 任务暂停 </li>
        /// <li> 7 = 任务删除中 </li>
        /// <li> 8 = 任务删除异常 </li>
        /// <li> 9 = 任务删除</li>
        /// <li> 10 = 定时任务暂停中 </li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 目标地址
        /// </summary>
        [JsonProperty("TargetAddress")]
        public string TargetAddress{ get; set; }

        /// <summary>
        /// 付费模式
        /// <li>1 = 试用版本</li>
        /// <li> 2 = 付费版本 </li>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 订单状态
        /// <li>1 = 正常</li>
        /// <li> 2 = 欠费 </li>
        /// </summary>
        [JsonProperty("OrderState")]
        public long? OrderState{ get; set; }

        /// <summary>
        /// 任务分类
        /// <li>1 = PC</li>
        /// <li> 2 = Mobile </li>
        /// </summary>
        [JsonProperty("TaskCategory")]
        public long? TaskCategory{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 定时任务cron表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// 定时任务启动状态
        /// <li>1 = 定时任务表达式生效</li>
        /// <li> 2 = 定时任务表达式未生效（一般为任务手动暂停）</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronState")]
        public long? CronState{ get; set; }

        /// <summary>
        /// 任务当前绑定的标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagInfoList")]
        public KeyValuePair[] TagInfoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "NodeIpType", this.NodeIpType);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TargetAddress", this.TargetAddress);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "OrderState", this.OrderState);
            this.SetParamSimple(map, prefix + "TaskCategory", this.TaskCategory);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamSimple(map, prefix + "CronState", this.CronState);
            this.SetParamArrayObj(map, prefix + "TagInfoList.", this.TagInfoList);
        }
    }
}


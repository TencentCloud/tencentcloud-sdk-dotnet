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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowRunNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>节点ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>节点类型</p><p>枚举值：</p><ul><li>0： 未指定</li><li>1： 开始节点</li><li>2： 参数提取节点</li><li>3： 大模型节点</li><li>4： 知识问答节点</li><li>5： 知识检索节点</li><li>6： 标签提取节点</li><li>7： 代码执行节点</li><li>8： 工具节点</li><li>9： 逻辑判断节点</li><li>10： 消息节点</li><li>11： 选项卡节点</li><li>12： 循环节点</li><li>13： 意图识别节点</li><li>14： 工作流节点</li><li>15： 插件节点</li><li>16： 结束节点</li><li>17： 变量聚合节点</li><li>18： 批处理节点</li><li>19： 消息队列节点</li><li>20： 数据库节点</li><li>21： 变量赋值节点</li><li>22： 变量转换节点</li><li>23： Agent节点</li><li>24： 注释节点</li><li>25： 文件收集节点</li><li>26： 文本收集节点</li><li>27： Widget 节点</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeType")]
        public ulong? NodeType{ get; set; }

        /// <summary>
        /// <p>节点名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>状态</p><p>枚举值：</p><ul><li>0： 初始状态</li><li>1： 运行中</li><li>2： 运行成功</li><li>3： 运行失败</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>输入</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// <p>输出</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// <p>任务输出</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskOutput")]
        public string TaskOutput{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// <p>花费时长，单位为毫秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostMilliSeconds")]
        public ulong? CostMilliSeconds{ get; set; }

        /// <summary>
        /// <p>大模型输出信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatisticInfos")]
        public StatisticInfo[] StatisticInfos{ get; set; }

        /// <summary>
        /// <p>错误代码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailCode")]
        public string FailCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "TaskOutput", this.TaskOutput);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "CostMilliSeconds", this.CostMilliSeconds);
            this.SetParamArrayObj(map, prefix + "StatisticInfos.", this.StatisticInfos);
            this.SetParamSimple(map, prefix + "FailCode", this.FailCode);
        }
    }
}


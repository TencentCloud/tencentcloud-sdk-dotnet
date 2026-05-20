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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitAutoRiggingJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>人形角色需采用标准姿态（A Pose 或 T Pose），尽量保持无动作状态。<br>模型中不应包含人体以外的组件（如武器、坐骑、翅膀等），避免松散衣物、配饰及复杂发型。<br>非人形角色建议上传二足、四足、鸟类等单一生命体模型，姿态应尽量简洁，无夸张或复杂动作，且不支持动作模版生成。3D模型文件必选其一，参考值：<br>FBX：3D模型文件，格式为FBX，文件大小不超过60Mb；<br>GLB：3D模型文件，格式为GLB，文件大小不超过60Mb；</p>
        /// </summary>
        [JsonProperty("File3D")]
        public InputFile3D File3D{ get; set; }

        /// <summary>
        /// <p>预设动作类型，参考值：</p><ol><li>回旋踢  </li><li>左勾拳  </li><li>蓄力攻击  </li><li>蓄力出拳  </li><li>二连击打  </li><li>二连击打-2  </li><li>后撤  </li><li>受击  </li><li>受击-2  </li><li>受击-3  </li><li>受击倒地-1  </li><li>受击倒地-2  </li><li>落地  </li><li>沮丧  </li><li>割喉  </li><li>刺拳  </li><li>连续击打  </li><li>踢腿  </li><li>侧踢  </li><li>打太极  </li><li>后空翻  </li><li>蹲姿转体  </li><li>走路-1  </li><li>走路-2  </li><li>走路-3  </li><li>待机-1  </li><li>待机-2  </li><li>街舞  </li><li>扭扭舞  </li><li>左转弯  </li><li>右转弯  </li><li>慢跑  </li><li>慢跑-2  </li><li>奔跑  </li><li>冲刺跑-1  </li><li>冲刺跑-2  </li><li>冲刺跑-3  </li><li>原地跳-1  </li><li>滑铲  </li><li>向前大跳  </li><li>向前大跳-2  </li><li>跨越  </li><li>恐吓  </li><li>向前跌倒  </li><li>右转  </li><li>原地跳-2  </li><li>转身  </li><li>发送冲击波</li></ol>
        /// </summary>
        [JsonProperty("MotionType")]
        public long? MotionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "File3D.", this.File3D);
            this.SetParamSimple(map, prefix + "MotionType", this.MotionType);
        }
    }
}


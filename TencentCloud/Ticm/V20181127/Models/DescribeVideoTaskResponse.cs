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

namespace TencentCloud.Ticm.V20181127.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务状态，取值：
        /// WAITING：等待中；
        /// PROCESSING：处理中；
        /// FINISH：已完成。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务开始执行的时间，采用 ISO 日期格式。
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// 任务执行完毕的时间，采用 ISO 日期格式。
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 视频内容审核智能画面鉴黄任务的查询结果。
        /// </summary>
        [JsonProperty("PornResult")]
        public VodPornReviewResult PornResult{ get; set; }

        /// <summary>
        /// 视频内容审核智能画面鉴恐任务的查询结果。
        /// </summary>
        [JsonProperty("TerrorismResult")]
        public VodTerrorismReviewResult TerrorismResult{ get; set; }

        /// <summary>
        /// 视频内容审核智能画面鉴政任务的查询结果。
        /// </summary>
        [JsonProperty("PoliticalResult")]
        public VodPoliticalReviewResult PoliticalResult{ get; set; }

        /// <summary>
        /// 视频内容审核 Ocr 文字鉴政任务的查询结果。
        /// </summary>
        [JsonProperty("PoliticalOcrResult")]
        public VodPoliticalOcrReviewResult PoliticalOcrResult{ get; set; }

        /// <summary>
        /// 视频内容审核 Asr 文字鉴黄任务的查询结果。
        /// </summary>
        [JsonProperty("PornAsrResult")]
        public VodPornAsrReviewResult PornAsrResult{ get; set; }

        /// <summary>
        /// 视频内容审核 Asr 文字鉴政任务的查询结果。
        /// </summary>
        [JsonProperty("PoliticalAsrResult")]
        public VodPoliticalAsrReviewResult PoliticalAsrResult{ get; set; }

        /// <summary>
        /// 视频内容审核 Ocr 文字鉴黄任务的查询结果。
        /// </summary>
        [JsonProperty("PornOcrResult")]
        public VodPornOcrResult PornOcrResult{ get; set; }

        /// <summary>
        /// 原始视频的元信息。
        /// </summary>
        [JsonProperty("MetaData")]
        public VodMetaData MetaData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamObj(map, prefix + "PornResult.", this.PornResult);
            this.SetParamObj(map, prefix + "TerrorismResult.", this.TerrorismResult);
            this.SetParamObj(map, prefix + "PoliticalResult.", this.PoliticalResult);
            this.SetParamObj(map, prefix + "PoliticalOcrResult.", this.PoliticalOcrResult);
            this.SetParamObj(map, prefix + "PornAsrResult.", this.PornAsrResult);
            this.SetParamObj(map, prefix + "PoliticalAsrResult.", this.PoliticalAsrResult);
            this.SetParamObj(map, prefix + "PornOcrResult.", this.PornOcrResult);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


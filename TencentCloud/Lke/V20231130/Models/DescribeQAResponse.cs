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

    public class DescribeQAResponse : AbstractModel
    {
        
        /// <summary>
        /// QA业务ID
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

        /// <summary>
        /// 问题
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 答案
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("CustomParam")]
        public string CustomParam{ get; set; }

        /// <summary>
        /// 来源 1-文档生成问答对  2-批量导入问答对  3-单条手动录入问答对
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// 来源描述
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 状态 <br>1-未校验  2-未发布 3-发布中 4-已发布  5-发布失败 6-不采纳 7-审核中  8-审核失败  9-审核失败申诉后人工审核中  11-审核失败申诉后人工审核不通过  12-已过期  13-超量失效  14-超量失效恢复 19-学习中  20-学习失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// 是否允许校验
        /// </summary>
        [JsonProperty("IsAllowAccept")]
        public bool? IsAllowAccept{ get; set; }

        /// <summary>
        /// 是否允许删除
        /// </summary>
        [JsonProperty("IsAllowDelete")]
        public bool? IsAllowDelete{ get; set; }

        /// <summary>
        /// 是否允许编辑
        /// </summary>
        [JsonProperty("IsAllowEdit")]
        public bool? IsAllowEdit{ get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// 文档名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文档类型
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 分片ID
        /// </summary>
        [JsonProperty("SegmentBizId")]
        public string SegmentBizId{ get; set; }

        /// <summary>
        /// 分片内容
        /// </summary>
        [JsonProperty("PageContent")]
        public string PageContent{ get; set; }

        /// <summary>
        /// 分片高亮内容
        /// </summary>
        [JsonProperty("Highlights")]
        public Highlight[] Highlights{ get; set; }

        /// <summary>
        /// 分片内容
        /// </summary>
        [JsonProperty("OrgData")]
        public string OrgData{ get; set; }

        /// <summary>
        /// 标签适用范围
        /// </summary>
        [JsonProperty("AttrRange")]
        public long? AttrRange{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabel[] AttrLabels{ get; set; }

        /// <summary>
        /// 有效开始时间，unix时间戳
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// 有效结束时间，unix时间戳，0代表永久有效
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// 相似问列表信息
        /// </summary>
        [JsonProperty("SimilarQuestions")]
        public SimilarQuestion[] SimilarQuestions{ get; set; }

        /// <summary>
        /// 问题和答案文本审核状态 1审核失败
        /// </summary>
        [JsonProperty("QaAuditStatus")]
        public ulong? QaAuditStatus{ get; set; }

        /// <summary>
        /// 答案中的图片审核状态 1审核失败
        /// </summary>
        [JsonProperty("PicAuditStatus")]
        public ulong? PicAuditStatus{ get; set; }

        /// <summary>
        /// 答案中的视频审核状态 1审核失败
        /// </summary>
        [JsonProperty("VideoAuditStatus")]
        public ulong? VideoAuditStatus{ get; set; }

        /// <summary>
        /// 问题描述
        /// </summary>
        [JsonProperty("QuestionDesc")]
        public string QuestionDesc{ get; set; }

        /// <summary>
        /// 问答是否停用，false:未停用，true已停用
        /// </summary>
        [JsonProperty("IsDisabled")]
        public bool? IsDisabled{ get; set; }

        /// <summary>
        /// 从根节点开始的路径分类ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CateBizIdPath")]
        public string[] CateBizIdPath{ get; set; }

        /// <summary>
        /// 从根节点开始的路径分类名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CateNamePath")]
        public string[] CateNamePath{ get; set; }

        /// <summary>
        /// 问答生效域: 1-停用；2-仅开发域；3-仅发布域；4-全域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableScope")]
        public long? EnableScope{ get; set; }

        /// <summary>
        /// 问答关联的文档生效域
        /// </summary>
        [JsonProperty("DocEnableScope")]
        public long? DocEnableScope{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "CustomParam", this.CustomParam);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "IsAllowAccept", this.IsAllowAccept);
            this.SetParamSimple(map, prefix + "IsAllowDelete", this.IsAllowDelete);
            this.SetParamSimple(map, prefix + "IsAllowEdit", this.IsAllowEdit);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "SegmentBizId", this.SegmentBizId);
            this.SetParamSimple(map, prefix + "PageContent", this.PageContent);
            this.SetParamArrayObj(map, prefix + "Highlights.", this.Highlights);
            this.SetParamSimple(map, prefix + "OrgData", this.OrgData);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamArrayObj(map, prefix + "SimilarQuestions.", this.SimilarQuestions);
            this.SetParamSimple(map, prefix + "QaAuditStatus", this.QaAuditStatus);
            this.SetParamSimple(map, prefix + "PicAuditStatus", this.PicAuditStatus);
            this.SetParamSimple(map, prefix + "VideoAuditStatus", this.VideoAuditStatus);
            this.SetParamSimple(map, prefix + "QuestionDesc", this.QuestionDesc);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
            this.SetParamArraySimple(map, prefix + "CateBizIdPath.", this.CateBizIdPath);
            this.SetParamArraySimple(map, prefix + "CateNamePath.", this.CateNamePath);
            this.SetParamSimple(map, prefix + "EnableScope", this.EnableScope);
            this.SetParamSimple(map, prefix + "DocEnableScope", this.DocEnableScope);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

